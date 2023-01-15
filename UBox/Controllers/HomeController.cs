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
        private readonly IAvatarImage _avatar;
        public HomeController(IProfile profile, IAvatarImage avatar)
        {
            _profile = profile;
            _avatar = avatar;
        }




        [HttpGet]
        [Authorize(AuthenticationSchemes = CookieAuthenticationDefaults.AuthenticationScheme)]
        public IActionResult Index()
        {
            ProfileIconModel obj = new ProfileIconModel();
            obj.user = _profile.MyProfile(User.Identity.Name);
            string imreBase64Data = Convert.ToBase64String(_avatar.getAvatarImage(obj.user.Id).ImageData);
            obj.imageDataUrl = string.Format("data:image/png;base64,{0}", imreBase64Data);
            return View(obj);
        }
    }
}
