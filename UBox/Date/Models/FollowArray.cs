using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace UBox.Date.Models
{
    public class FollowArray
    {
        [Key]
        public int Id { get; set; }
        //який користувач підписаний
        
        public User FollowerUser { get; set; }

        public int FollowerUserId { get; set; }
        //На кого користувач підписаний
        
        public User FollowingUser { get; set; }
       
        public int FollowingUserId { get; set; }

    }
}
