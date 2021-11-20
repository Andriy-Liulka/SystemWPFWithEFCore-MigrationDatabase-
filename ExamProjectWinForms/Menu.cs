using Domain.Models;
using ExamProject.Domain.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ExamProjectWinForms
{
    public partial class Menu : Form
    {
        private readonly ApplicationDbContext _context = new ApplicationDbContext();
        public Menu()
        {
            InitializeComponent();
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            //ChooseAuthor_Combobox.DataSource = _context.Authors;
        }

        private void AddBook_button_Click(object sender, EventArgs e)
        {
            Book currentBook = GetBook();
            if (currentBook != null)
            {
                _context.Books.Add(currentBook);
                _context.SaveChanges();
            }
            


        }
        private Book GetBook()
        {
            Book book = new Book();
            try
            {
                book.Name = Name_textBox.Text;
                book.UserkId = Form1.CurrentUser;
                book.VersionName = VersionName_textBox.Text;
                book.QuantityOfPages = int.Parse(QuantityOfPages_textBox.Text);
                book.Genres = Genre_textBox.Text;
                book.HasContinuation=HasSequel_checkBox.Enabled;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                book = null;
            }
            return book;
        }
    }
}
