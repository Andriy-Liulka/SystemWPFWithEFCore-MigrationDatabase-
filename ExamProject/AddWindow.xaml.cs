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
    /// Interaction logic for AddWindow.xaml
    /// </summary>
    public partial class AddWindow : Window
    {
        private readonly ApplicationDbContext _context = new ApplicationDbContext();
        public AddWindow()
        {
            InitializeComponent();
        }

        private void Add_Button_Click(object sender, RoutedEventArgs e)
        {
            Book currentBook = GetBook();
            if (currentBook != null)
            {
                _context.Books.Add(currentBook);
                _context.SaveChanges();
                ResetAddBooks();
                Books_ComboBox.ItemsSource = (from m in _context.Books select m.Name).ToList();
            }
        }
        private Book GetBook()
        {
            Book book = new Book();
            try
            {
                book.Name = Name_TextBox.Text;
                book.UserkId = MainWindow.CurrentUser;
                book.VersionName = VersionName_TextBox.Text;
                book.QuantityOfPages = int.Parse(QuantityOfPages_TextBox.Text);
                book.Genres = Genres_TextBox.Text;
                book.HasContinuation = HasSequel_CheckBox.IsChecked ?? false;
                book.Price = decimal.Parse(Price_TextBox.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                book = null;
            }
            return book;
        }
        private void ResetAddBooks()
        {
            Name_TextBox.Text = String.Empty;
            VersionName_TextBox.Text = String.Empty;
            QuantityOfPages_TextBox.Text = String.Empty;
            Genres_TextBox.Text = String.Empty;
            HasSequel_CheckBox.IsChecked = false;
            Price_TextBox.Text = String.Empty;
        }
        private void MenuWindow_Loaded(object sender, RoutedEventArgs e)
        {
            try
            {
                Books_ComboBox.ItemsSource = (from m in _context.Books select m.Name).ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void ResetAddAuthors()
        {
            Books_ComboBox.SelectedItem = null;
            FirstName_textBox.Text = String.Empty;
            LastName_textBox.Text = String.Empty;
        }

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            Author author = GetAuthor();
            if (author != null)
            {
                _context.Authors.Add(author);
                _context.SaveChanges();
                ResetAddAuthors();
            }
            
        }

        private Author GetAuthor()
        {
            Author author = new Author();
            try
            {
                author.Name = FirstName_textBox.Text;
                author.Surname = LastName_textBox.Text;
                
                string selectedItem=Books_ComboBox.SelectedItem.ToString();
                author.BookId = _context.Books.FirstOrDefault(x => x.Name.Equals(selectedItem)).Id;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                author = null;
            }
            return author;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            Menu menu = new Menu();
            menu.Show();
        }
    }
}
