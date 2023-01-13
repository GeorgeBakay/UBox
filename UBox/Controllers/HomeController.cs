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
            return View();
        }
        [Authorize(AuthenticationSchemes = CookieAuthenticationDefaults.AuthenticationScheme)]
        public IActionResult GetProfileIcon()
        {
            ProfileIconModel obj = new ProfileIconModel();
            obj.user = _profile.MyProfile(User.Identity.Name);
            obj.image = byteArrayToImage(obj.user.Image);
            return PartialView(obj);
        }
        public Image byteArrayToImage(byte[] byteArrayIn)
        {
            Image returnImage = null;
            try
            {
                MemoryStream ms = new MemoryStream(byteArrayIn, 0, byteArrayIn.Length);
                ms.Write(byteArrayIn, 0, byteArrayIn.Length);
                returnImage = Image.FromStream(ms);//Exception occurs here
            }
            catch { }
            return returnImage;
        }
    }
}
