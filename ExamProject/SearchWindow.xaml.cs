using ExamProject.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace ExamProject
{
    /// <summary>
    /// Interaction logic for SearchWindow.xaml
    /// </summary>
    public partial class SearchWindow : Window
    {
        private readonly ApplicationDbContext _context = new ApplicationDbContext();
        public SearchWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            try
            {
                Category_ComboBox.ItemsSource = new List<string> {"Name","Author","Genre"};
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Category_ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            try
            {
                string selectedItem = Category_ComboBox.SelectedItem.ToString();
                switch (selectedItem)
                {
                    case "Name":
                        {
                            CurrentCategory_ComboBox.ItemsSource=(from m in _context.Books select m.Name).ToList();
                            break;
                        }
                    case "Author":
                        {
                            CurrentCategory_ComboBox.ItemsSource = (from m in _context.Authors select m.Surname).ToList();
                            break;
                        }
                    case "Genre":
                        {
                            CurrentCategory_ComboBox.ItemsSource = (from m in _context.Books select m.Genres).ToList();
                            break;
                        }
                    default:
                        {
                            throw new InvalidOperationException();
                        }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void CurrentCategory_ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            try
            {
                IEnumerable<object> selectData = null;

                string selectedItem = Category_ComboBox.SelectedItem.ToString();
                string selectedItemSecondCombobox=CurrentCategory_ComboBox.SelectedItem.ToString();
                switch (selectedItem)
                {
                    case "Name":
                        {
                            selectData = (from t in _context.Books
                                          join auth in _context.Authors on t.Id equals auth.BookId
                                          where t.Name == selectedItemSecondCombobox
                                          select t).ToList();
                            break;
                        }
                    case "Author":
                        {
                            selectData = (from t in _context.Books
                                         join auth in _context.Authors on t.Id equals auth.BookId
                                         where auth.Surname == selectedItemSecondCombobox
                                          select t).ToList();
                            break;
                        }
                    case "Genre":
                        {
                            selectData = (from t in _context.Books
                                         join auth in _context.Authors on t.Id equals auth.BookId
                                         where t.Genres == selectedItemSecondCombobox
                                          select t).ToList();
                            break;
                        }
                    default:
                        {
                            throw new InvalidOperationException();
                        }
                }
                FullDataGrid.ItemsSource = selectData;
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
            }

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            Menu sw = new Menu();
            sw.Show();
        }
    }
}
