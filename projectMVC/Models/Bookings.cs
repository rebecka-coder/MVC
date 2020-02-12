using System;
namespace projectMVC.Models
{
    public class Bookings
    {
        //Properties
        public string Treatment { get; set; }

        public string Datepicker { get; set; }

        public string Namn { get; set; }

        public string Adress { get; set; }

        public string Postnummer { get; set; }

        public string Stad { get; set; }

        public string Telefonnummer { get; set; }

        public string Epost { get; set; }

        public bool ConfirmationEmail { get; set; }

        public bool SmsReminder { get; set; }

        public Bookings()
        {

        }
    }
 }
