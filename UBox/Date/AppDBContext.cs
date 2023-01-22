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
        protected override void OnModelCreating(ModelBuilder modelbuilder)
        {
            base.OnModelCreating(modelbuilder);
            modelbuilder.Entity<FollowArray>().HasOne<User>(e => e.FollowerUser).WithOne().OnDelete(DeleteBehavior.ClientSetNull);
            modelbuilder.Entity<FollowArray>().HasOne<User>(e => e.FollowingUser).WithOne().OnDelete(DeleteBehavior.ClientSetNull);
        }
        public DbSet<User> Users { get; set; }
        public DbSet<UserAvatarImage> AvatarImages{ get; set; }
        public DbSet<Post> Posts { get; set; }
        public DbSet<FollowArray> FollowArrays { get; set; }

    }
}
