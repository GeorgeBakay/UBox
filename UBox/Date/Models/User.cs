 using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace UBox.Date.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string UserName { get; set; }
        [Required]
        public string Email { get; set; }
        public byte[] Image { get; set; }
        [Required]
        [MinLength(8)]
        public string Password { get; set; }

        [MaxLength(2)]
        [Column(TypeName = "varchar(2)")]
        public string Country { get; set; }
        public string City { get; set; }
        
        public DateTime DateCreate { get; set; }
    }
}
