using ExamProject.Domain.Models;
using MyProject.Domain.Models;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ExamProject
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void ButtonSignInClick(object sender, RoutedEventArgs e)
        {
            try
            {
                User existingUser = _context.Users.FirstOrDefault(x => x.Login.Equals(Login_TextBox.Text));
                CurrentUser = existingUser.Id;
                if (existingUser.Password.Equals(Password_TextBox.Text))
                {
                    this.Hide();
                    Menu sw = new Menu();
                    sw.Show();
                }
                else
                {
                    Error_textBlock.Text = "You entered incorrect login or password!!";
                }
            }
            catch (Exception)
            {
                Error_textBlock.Text = "You entered incorrect login or password!!";
            }


        }

        public static int CurrentUser = default; 
        private readonly ApplicationDbContext _context = new ApplicationDbContext();
    }
}
