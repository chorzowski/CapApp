using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CapApp.Models
{
    public class LoginViewModel
    {
        [Required(ErrorMessage = "Prosze podać nazwe użytkownika.")]
        public string UserName { get; set; }
        [Required(ErrorMessage = "Prosze podać hasło.")]
        public string Password { get; set; }
    }
}