using System;
using System.ComponentModel.DataAnnotations;

namespace projectMVC.Models
{
    public class BookingModel
    {
        //Properties
        [Required(ErrorMessage = "Välj behandling!")]
        public string treatment { get; set; }

        [Required(ErrorMessage = "Välj datum!")]
        public string datepicker { get; set; }

        [Required(ErrorMessage = "Fyll i för-och efternamn!")]
        public string Namn { get; set; }

        [Required(ErrorMessage = "Fyll i adress!")]
        public string Adress { get; set; }

        [Required(ErrorMessage = "Fyll i postnummer!")]
        [MaxLength(5, ErrorMessage = "Max fem siffror")]
        public String Postnummer { get; set; }

        [Required(ErrorMessage = "Fyll i stad!")]
        public string Stad { get; set; }

        [Required(ErrorMessage = "Fyll i telefonnummer!")]
        public string Telefonnummer { get; set; }

        [Required(ErrorMessage = "Fyll i epost!")]
        public string Epost { get; set; }

        public bool checkbox { get; set; }

        public BookingModel()
        {
        }
    }
}
