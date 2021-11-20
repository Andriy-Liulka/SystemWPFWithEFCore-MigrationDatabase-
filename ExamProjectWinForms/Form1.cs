using ExamProject.Domain.Models;
using Microsoft.VisualBasic.ApplicationServices;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void SignInButton_Click(object sender, EventArgs e)
        {
            MyProject.Domain.Models.User existingUser = _context.Users.FirstOrDefault(x => x.Login.Equals(Login_textBox.Text));
            CurrentUser = existingUser.Id;
            if (existingUser.Password.Equals(Password_textBox.Text))
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
        public static int CurrentUser = default;
        private readonly ApplicationDbContext _context = new ApplicationDbContext();
    }
}
