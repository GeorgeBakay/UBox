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
        private readonly IProfile _Profile;
        public ProfileController(IProfile profile)
        {
            _Profile = profile;
        }
        [Authorize(AuthenticationSchemes = CookieAuthenticationDefaults.AuthenticationScheme)]
        public ViewResult MyProfile()
        {
            ProfileViewModel obj = new ProfileViewModel();
            obj.user = _Profile.MyProfile(User.Identity.Name);
            return View(obj);
        }
    }
}
