using MyProject.Domain.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class Book
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey(nameof(User))]
        public int UserkId { get; set; }
        public virtual User User { get; set; }

        [Required]
        [MinLength(1)]
        [MaxLength(100)]
        public string Name { get; set; }

        [Required]
        [MinLength(1)]
        [MaxLength(100)]
        public string VersionName { get; set; }

        [Required]
        [MinLength(1)]
        [MaxLength(100)]
        public int QuantityOfPages { get; set; }

        [Required]
        [MinLength(1)]
        [MaxLength(100)]
        public string Genres { get; set; }

        [Required]
        public bool HasContinuation { get; set; }
        [Required]
        public decimal Price { get; set; }

    }
}
