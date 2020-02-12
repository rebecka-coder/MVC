using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using projectMVC.Models;
using Microsoft.AspNetCore.Http;

namespace projectMVC.Controllers
{
    public class HomeController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet("/Omoss")]
        public IActionResult About()
        {
            ViewData["Message"] = "Våra öppettider:";
            ViewBag.text = "Mån-Fre: 08:00 - 18:00";
            string f = "Hitta hit: Kontorsgatan 12, 832 14 Östersund. Kontakt: 063- 12 12 12 E-mail: harfin@gmail.com.";
            HttpContext.Session.SetString("footer", f);

            return View();
        }
        [HttpGet("/Bokatid")]
        public IActionResult Booking()
        {
            string f2 = HttpContext.Session.GetString("footer");
            ViewBag.footer = f2;
            return View();
        }
        [HttpGet("/Behandlingar")]
        public IActionResult Treatments()
        {
            ViewData["Message"] = "Våra öppettider:";
            ViewBag.text = "Mån-Fre: 08:00 - 18:00";
            string f2 = HttpContext.Session.GetString("footer");
            ViewBag.footer = f2;
            return View();
        }
        [HttpPost("/Bokatid")]
        public IActionResult Booking(BookingModel model)
        {
            if (ModelState.IsValid)
            {
  
                //Läs in befintlig 
                var JsonStr = System.IO.File.ReadAllText("bookings.json");
                var JsonObj = JsonConvert.DeserializeObject<List<BookingModel>>(JsonStr);
                JsonObj.Add(model);

                //Konvertera till JSON-sträng
                //Lagra
                System.IO.File.WriteAllText("bookings.json", JsonConvert.SerializeObject(JsonObj, Formatting.Indented));

                ModelState.Clear(); //Rensar alla fält
 
            }
            return View();

        }
        [HttpGet("/Bokningar")]
        public IActionResult Bookings(BookingModel model)
        {
            //Läs in JSON fil, och parsa
            var JsonStr = System.IO.File.ReadAllText("bookings.json");
            var JsonObj = JsonConvert.DeserializeObject<IEnumerable<BookingModel>>(JsonStr);
            return View(JsonObj);
            
        }

    }
}
