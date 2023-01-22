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
    public class SearchController : Controller
    {
        private readonly IProfile _profile;
        public SearchController(IProfile profile)
        {
            _profile = profile;
        }
        [HttpGet]
        [Authorize(AuthenticationSchemes = CookieAuthenticationDefaults.AuthenticationScheme)]
        public IActionResult ProfileSearch()
        {
            return View();
        }
        [HttpPost]
        [Authorize(AuthenticationSchemes = CookieAuthenticationDefaults.AuthenticationScheme)]
        public IActionResult ProfileSearch(SearchModel model)
        {
            SearchModel obj = new SearchModel();
            obj.Name = model.Name;
            obj.ListOfUser = _profile.SearchProfile(model.Name);
            return View(obj);
        }
    }
}
