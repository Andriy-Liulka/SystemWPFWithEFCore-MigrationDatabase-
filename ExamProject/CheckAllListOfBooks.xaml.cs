using Domain.Models;
using ExamProject.Domain.Models;
using Microsoft.EntityFrameworkCore;
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
    /// Interaction logic for CheckAllListOfBooks.xaml
    /// </summary>
    public partial class CheckAllListOfBooks : Window
    {
        private readonly ApplicationDbContext _context = new ApplicationDbContext();
        public CheckAllListOfBooks()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            try
            {
                var selectData = from t in _context.Books 
                                 join auth in _context.Authors on t.Id equals auth.BookId
                                 select t;
                Datagrid.ItemsSource = selectData.ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            Menu menu = new Menu();
            menu.Show();
        }

    }
}
