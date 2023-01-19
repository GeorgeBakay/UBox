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
        private readonly IAvatarImage _avatar;
        private readonly IPost _post;


        public ProfileController(IProfile profile, IAvatarImage avatar, IPost post)
        {
            _profile = profile;
            _avatar = avatar;
            _post = post;
        }

        
        [HttpGet]
        [Authorize(AuthenticationSchemes = CookieAuthenticationDefaults.AuthenticationScheme)]
        public async Task<IActionResult> MyProfile()
        {
            ProfileModel obj = new ProfileModel();
            obj.user = _profile.MyProfile(User.Identity.Name);
            
            if (obj.user == null)
            {
                await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
                return RedirectToAction("Login", "User");
            }
            byte[] image = _avatar.getAvatarImage(obj.user.Id).ImageData;
            string imreBase64Data = Convert.ToBase64String(image);
            obj.imageAvatar = string.Format("data:image/png;base64,{0}", imreBase64Data);


            obj.posts = _post.getPosts(User.Identity.Name);
            return View(obj);
        }


    }
}
