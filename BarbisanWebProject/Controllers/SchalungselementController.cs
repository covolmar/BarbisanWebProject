using BarbisanWebProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BarbisanWebProject.Controllers
{
    public class SchalungselementController : Controller
    {
        // GET: Schalungselemente
        public ActionResult Schalungselemente()
        {

			var schalungselement270X240 = new Schalungselement( )
			{
				Id = 1,
				Artikelnummer = 271,
				Name = "Peri Trio",
				Bezeichnung = "Trio-Element TR 270 x 240",
				Preis = 60
            };

            var schalungselement270x120 = new Schalungselement()
            {
				Id = 2,
                Artikelnummer = 272,
                Name = "Peri Trio",
                Bezeichnung = "Trio-Element TR 270 x 120",
				Preis = 120
		};

            var schalungselement270x90 = new Schalungselement()
            {
				Id = 3,
                Artikelnummer = 273,
                Name = "Peri Trio",
                Bezeichnung = "Trio-Element TR 270 x 90",
				Preis = 180
	};

            var elementList = new List<Schalungselement>();
            elementList.Add(schalungselement270x120);
            elementList.Add(schalungselement270X240);
            elementList.Add(schalungselement270x90);

            return View(elementList);
        }
    }
}