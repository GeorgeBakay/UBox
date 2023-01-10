using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace UBox.ViewModels
{
    public class RegisterModel
    {
        [Required(ErrorMessage = "Вкажіть ім'я")]
        public string UserName { get; set; }
        [Required(ErrorMessage = "Email не вказаний")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Не введений пароль")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "Пароль введений невірно")]
        public string ConfirmPassword { get; set; }
    }
}
