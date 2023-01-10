using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UBox.Date.Models;

namespace UBox.Date.Interface
{
    public interface IProfile
    {
        public User MyProfile(string UserName);
      
    }
}
