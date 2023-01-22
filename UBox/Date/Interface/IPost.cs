using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UBox.Date.Models;
using UBox.ViewModels;

namespace UBox.Date.Interface
{
    public interface IPost
    {
        public List<Post> getRecomendetPost(string userName);
        public List<Post> getPosts(string userName);
        public void addPost(string userName,AddPostModel model,string filePath);
    }
}
