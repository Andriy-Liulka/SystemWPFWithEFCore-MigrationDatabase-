using Domain.Models;
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
    /// Interaction logic for DeleteWindow.xaml
    /// </summary>
    public partial class DeleteWindow : Window
    {
        private readonly ApplicationDbContext _context = new ApplicationDbContext();
        public DeleteWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            Menu menu = new Menu();
            menu.Show();
        }

        private void Delete_Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string selectedItem = ComboBox_WithBooks.SelectedItem.ToString();
                Book book = _context.Books.FirstOrDefault(x => x.Name.Equals(selectedItem));
                _context.Books.Remove(book);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            
            try
            {
                ComboBox_WithBooks.ItemsSource = (from m in _context.Books select m.Name).ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
