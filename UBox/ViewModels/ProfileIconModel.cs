using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UBox.Date.Models;
using static System.Net.Mime.MediaTypeNames;

namespace UBox.ViewModels
{
    public class ProfileIconModel
    {
        public User user { get; set; }
        public System.Drawing.Image image { get; set; }

    }
}
