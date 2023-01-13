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
        [Authorize(AuthenticationSchemes = CookieAuthenticationDefaults.AuthenticationScheme)]
        public ViewResult MyProfile()
        {
            ProfileViewModel obj = new ProfileViewModel();
            obj.user = _profile.MyProfile(User.Identity.Name);
            return View(obj);
        }
    }
}
