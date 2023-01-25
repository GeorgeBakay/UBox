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
            //modelbuilder.Entity<UserDetailInfo>().HasMany(u => u.posts).WithOne(c => c.User).OnDelete(DeleteBehavior.ClientSetNull);
            modelbuilder.Entity<UserDetailInfo>().HasMany(u => u.follower).WithOne(e => e.FollowerUser).OnDelete(DeleteBehavior.ClientSetNull);
            modelbuilder.Entity<UserDetailInfo>().HasMany(u => u.following).WithOne(e => e.FollowingUser).OnDelete(DeleteBehavior.ClientSetNull);

            modelbuilder.Entity<FollowArray>().HasOne<UserDetailInfo>(e => e.FollowerUser).WithMany(u => u.follower).OnDelete(DeleteBehavior.ClientSetNull);
            modelbuilder.Entity<FollowArray>().HasOne<UserDetailInfo>(e => e.FollowingUser).WithMany(u => u.following).OnDelete(DeleteBehavior.ClientSetNull);
            //modelbuilder.Entity<Post>().HasOne<UserDetailInfo>(e => e.User).WithMany(c => c.posts).HasForeignKey(o => o.Id).OnDelete(DeleteBehavior.ClientSetNull);
        }
        public DbSet<User> Users { get; set; }
        public DbSet<UserAvatarImage> AvatarImages{ get; set; }
        public DbSet<Post> Posts { get; set; }
        public DbSet<FollowArray> FollowArrays { get; set; }
        public DbSet<UserDetailInfo> UserDetailInfos { get; set; }
    }
}
