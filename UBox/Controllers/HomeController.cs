using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication.Cookies;
using UBox.Date.Interface;
using UBox.ViewModels;
using System.IO;
using System.Drawing;

namespace UBox.Controllers
{
    public class HomeController : Controller
    {
        private readonly IProfile _profile;
        public HomeController(IProfile profile)
        {
            _profile = profile;
        }
        [HttpGet]
        [Authorize(AuthenticationSchemes = CookieAuthenticationDefaults.AuthenticationScheme)]
        public IActionResult Index()
        {
            ProfileIconModel obj = new ProfileIconModel();
            obj.user = _profile.MyProfile(User.Identity.Name);
            string imreBase64Data = Convert.ToBase64String(obj.user.Image);
            obj.imageDataUrl = string.Format("data:image/png;base64,{0}", imreBase64Data);
            return View(obj);
        }
        [Authorize(AuthenticationSchemes = CookieAuthenticationDefaults.AuthenticationScheme)]
        public IActionResult GetProfileIcon()
        {
            ProfileIconModel obj = new ProfileIconModel();
            obj.user = _profile.MyProfile(User.Identity.Name);
            string imreBase64Data = Convert.ToBase64String(obj.user.Image);
            obj.imageDataUrl = string.Format("data:image/png;base64,{0}", imreBase64Data); 
            return PartialView(obj);
        }
      
    }
}
