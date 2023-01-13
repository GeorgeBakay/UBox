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
        public AppDBContext appDBContext;
        public ProfileRepository(AppDBContext _appDBContext)
        {
            this.appDBContext = _appDBContext;              
        }
        public User MyProfile(string UserName) {

             return appDBContext.Users.FirstOrDefault(u => u.UserName == UserName);
        } 
        
            
    }
}
