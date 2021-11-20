using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Domain.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MinLength(5)]
        [MaxLength(100)]
        public string Login { get; set; }
        [Required]
        [MinLength(5)]
        [DataType(DataType.Password)]
        [MaxLength(100)]
        public string Password { get; set; }

    }
}
