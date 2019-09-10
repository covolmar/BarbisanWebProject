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
			return View( GetSchalungselemente() );
        }


		public IEnumerable<Schalungselement> GetSchalungselemente()
		{
			var elementList = new List<Schalungselement>( );
			using( var ctx = new ApplicationDbContext( ) )
			{
				//elementList = ( from scha in ctx.Schalungselemente
				//				select new Schalungselement
				//				{
				//					Id = scha.Id,
				//					Artikelnummer = scha.Artikelnummer,
				//					Name = scha.Name,
				//					Bezeichnung = scha.Bezeichnung,
				//					Preis = scha.Preis
				//				} ).ToList( );


				elementList = ctx.Schalungselemente.ToList();

			}
			return elementList;
		}



    }
}