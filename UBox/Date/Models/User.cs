 using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace UBox.Date.Models
{
    public class User
    {
        [Key]   
        public int Id { get; set; }
        
        public string UserName { get; set; }
        public string Email { get; set; }
        public byte[] Image { get; set; }
        public string Password { get; set; }
        
        public DateTime DateCreate { get; set; }
    }
}
