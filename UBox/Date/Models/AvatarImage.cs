using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace UBox.Date.Models
{
    public class AvatarImage
    {
        [Key]
        public int id { get; set; }
        [Required]
        public byte[] ImageData { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }

    }
}
