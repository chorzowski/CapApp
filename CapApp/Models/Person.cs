using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CapApp.Models
{
    public class Person
    {

            [HiddenInput(DisplayValue=false)]
            public int PersonId { get; set; }

            [Required(ErrorMessage = "Prosze podać imię.")]
            [Display(Name="Imie")]
            public string Name { get; set; }

            [Required(ErrorMessage = "Prosze podać nazwisko.")]
            [Display(Name = "Nazwisko")]    
            public string LastName { get; set; }

            [Required(ErrorMessage = "Prosze podać numer telefonu.")]
            [RegularExpression(@"^(?:\(?\+?48)?(?:[-\.\(\)\s]*(\d)){9}\)?$$", ErrorMessage = "Zła długość numeru")]
            [Display(Name = "Numer telefonu")]
            public int TelephoneNumber { get; set; }

            [Required(ErrorMessage = "Prosze podać adres.")]
            [Display(Name = "Adres")]
            public string Address { get; set; }
    }
}