using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using UBox.Date;
using UBox.Date.Models;
using UBox.ViewModels;

namespace UBox.Controllers
{
    public class UserController : Controller
    {
        private AppDBContext db;

        public UserController(AppDBContext context)
        {
            db = context;
        }
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(LoginModel model)
        {
            if (ModelState.IsValid)
            {
                string hash = getHashCode(model.Password);
                User user = await db.Users.FirstOrDefaultAsync(u => u.UserName == model.UserName && u.Password == hash);
                if (user != null) 
                {
                    await Authenticate(model.UserName); // аутентификация

                    return RedirectToAction("Index", "Home");
                }
                ModelState.AddModelError("", "Некоректний логін або пароль");
            }
            return View(model);
        }

        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Register(RegisterModel model)
        {
            if (ModelState.IsValid)
            {
               
                User user = await db.Users.FirstOrDefaultAsync(u => u.UserName == model.UserName || u.Email == model.Email);

                if(model.Password.Length < 8)
                {
                    ModelState.AddModelError("", "Пароль повинен містити мінімум 8 символів");
                }
                else if (!model.Email.Contains("@"))
                {
                    ModelState.AddModelError("", "Формат email введений невірно");
                }
                else if (user == null)
                {
                    string hash = getHashCode(model.Password);
                    //var file = model.Image;
                    //var fileStream = file.OpenReadStream();
                    //byte[] bytes = new byte[file.Length];
                    //fileStream.Read(bytes, 0, (int)file.Length);

                    db.Users.Add(new User { UserName = model.UserName, Email = model.Email, Password = hash,/*Image = bytes,*/DateCreate = DateTime.Now }); 
                    await db.SaveChangesAsync();

                    await Authenticate(model.UserName); // аутентификация

                    return RedirectToAction("Index", "Home");
                }
                else
                    ModelState.AddModelError("", "Користувач з таким іменем або email вже існує");
            }
            return View(model);
        }
        private string getHashCode(string s)
        {
            byte[] bytes = Encoding.Unicode.GetBytes(s);
            MD5CryptoServiceProvider CSP = new MD5CryptoServiceProvider();
            byte[] byteHash = CSP.ComputeHash(bytes);
            StringBuilder sbHash = new StringBuilder();
            foreach (byte b in byteHash)
            {
                sbHash.Append(string.Format("{0:x2}", b));
            }
            string hash = sbHash.ToString();
            return hash;
        }
        private async Task Authenticate(string userName)
        {
            // создаем один claim
            var claims = new List<Claim>
            {
                new Claim(ClaimsIdentity.DefaultNameClaimType, userName)
            };
            
            // создаем объект ClaimsIdentity
            ClaimsIdentity id = new ClaimsIdentity(claims, "ApplicationCookie", ClaimsIdentity.DefaultNameClaimType, ClaimsIdentity.DefaultRoleClaimType);
            // установка аутентификационных куки
            await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, new ClaimsPrincipal(id));
        }
        
        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return RedirectToAction("Login", "User");
        }
    }
}
