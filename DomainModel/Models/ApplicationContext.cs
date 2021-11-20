using Domain.Models;
using Microsoft.EntityFrameworkCore;
using MyProject.Domain.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamProject.Domain.Models
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Author> Authors { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<User> Users { get; set; }
        public ApplicationDbContext()
        {
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=ANDRIJ-PC\\SQLSERVER2021;Database=ADO_NET_ExamProject_Database_Books;User Id=andriy;Password=Fylhsq;  Trusted_Connection=False;");
        }
    }

}
