using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UBox.Date.Models;

namespace UBox.Date
{
    public class AppDBContext: DbContext
    {
        public AppDBContext(DbContextOptions<AppDBContext> options) : base(options)
        {
        }
        public DbSet<User> Users { get; set; }
        public DbSet<UserAvatarImage> AvatarImages{ get; set; }
        public DbSet<Post> Posts { get; set; }
        public DbSet<UserFollowers> UserFollowers { get; set; }
    }
}
