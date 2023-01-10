using Microsoft.AspNetCore.Http;
using System;
using System.Web;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UBox.Date.Interface;
using UBox.Date.Models;

namespace UBox.Date.Repository
{
    public class ProfileRepository:IProfile
    {
        private readonly IHttpContextAccessor httpContextAccessor;
        public AppDBContext appDBContext;
        public ProfileRepository(AppDBContext appDBContext)
        {
            this.appDBContext = appDBContext;              
        }


        public User MyProfile(string UserName) {
            return appDBContext.Users.FirstOrDefault(u => u.UserName == UserName);
        } 
        
            
    }
}
