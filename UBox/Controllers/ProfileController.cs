using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UBox.Date.Interface;
using UBox.ViewModels;

namespace UBox.Controllers
{
    public class ProfileController : Controller
    {
        private readonly IProfile _profile;


        public ProfileController(IProfile profile)
        {
            _profile = profile;
        }

        
        [HttpGet]
        [Authorize(AuthenticationSchemes = CookieAuthenticationDefaults.AuthenticationScheme)]
        public async Task<IActionResult> MyProfile()
        {
            ProfileViewModel obj = new ProfileViewModel();
            obj.user = _profile.MyProfile(User.Identity.Name);
            if (obj.user == null)
            {
                await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
                return RedirectToAction("Login", "User");
            }
            string imreBase64Data = Convert.ToBase64String(obj.user.Image);
            obj.imageAvatar = string.Format("data:image/png;base64,{0}", imreBase64Data);
            return View(obj);
        }


    }
}
