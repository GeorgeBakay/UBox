using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using UBox.Date.Interface;
using UBox.Date.Models;
using UBox.ViewModels;

namespace UBox.Date.Repository
{
    public class PostRepository : IPost
    {
        private readonly AppDBContext appDBContext;
        public PostRepository(AppDBContext appDBContext)
        {
            this.appDBContext = appDBContext;
        }

        public void addPost( string userName, AddPostModel model,string filepath)
        {
            User thisUser = appDBContext.Users.FirstOrDefault(u => u.UserName == userName);
            List<string> tegs = new List<string> { };
            string type = Path.GetExtension(model.PostItem.FileName).ToLower();
            if(model.Description != null)
            {
                if (model.Description.Contains('#'))
                {
                    foreach (string teg in model.Description.Split(' '))
                    {
                        if (teg.Contains('#'))
                        {
                            string[] tegMass = teg.Split("#");
                            foreach (string el in tegMass)
                            {
                                tegs.Add(el);
                            }
                        }
                    }
                }
            } 
            appDBContext.Posts.Add(new Post
            {
                PostFilePath = filepath,
                FileType = type,
                Description = model.Description,
     
                PublishDate = DateTime.Now,
                UserId = thisUser.Id,
                User = thisUser,
               
            }) ;
            appDBContext.SaveChanges();
        }

        public List<Post> getPosts(string userName)
        {
            IEnumerable<Post> posts = appDBContext.Posts.Where(p => p.User.UserName == userName);
            return posts.OrderByDescending(u => u.PublishDate).ToList();
        }

        public List<Post> getRecomendetPost(string userName)
        {
            User thisUser = appDBContext.Users.FirstOrDefault(u => u.UserName == userName);
            IEnumerable<FollowArray> FollowArray = appDBContext.FollowArrays.Where(f => f.FollowerUser == thisUser);
            List<User> FollowingUser = new List<User>();
            foreach(FollowArray el in FollowArray)
            {
                FollowingUser.Add(el.FollowingUser);
            }
            List<Post> posts = new List<Post>();
            foreach(User el in FollowingUser)
            {
                IEnumerable<Post> postsEl = appDBContext.Posts.Where(p => p.User == el);
                posts.AddRange(postsEl.ToList());
            }
            IEnumerable<Post> sortedPost = posts.OrderBy(u => u.PublishDate);
            return sortedPost.ToList();

        }
    }
}
