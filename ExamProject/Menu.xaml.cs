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
    /// Interaction logic for Menu.xaml
    /// </summary>
    public partial class Menu : Window
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void MenuWindow_Loaded(object sender, RoutedEventArgs e)
        {

        }
        private void CheckDatabase_Button_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            CheckAllListOfBooks window = new CheckAllListOfBooks();
            window.Show();
        }
        private void AddWindow_Button_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            AddWindow window = new AddWindow();
            window.Show();

        }

        private void DeleteEntity_Button_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            DeleteWindow window = new DeleteWindow();
            window.Show();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            SearchWindow window = new SearchWindow();
            window.Show();
        }
    }
}
