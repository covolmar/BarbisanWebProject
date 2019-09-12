using BarbisanWebProject.Models;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.Owin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace BarbisanWebProject.Controllers
{
    public class SchalungselementController : Controller
    {

		private ApplicationSignInManager _signInManager;
		private ApplicationUserManager _userManager;

		// GET: Schalungselemente
		public ActionResult Schalungselemente()
        {
			return View( GetSchalungselemente() );
        }


		public ActionResult AddItem( )
		{
			string currentUserId = User.Identity.GetUserId( );
			if( Request.IsAuthenticated )
			{

			}

			return View( );
		}

		public ApplicationSignInManager SignInManager
		{
			get
			{
				return _signInManager ?? HttpContext.GetOwinContext( ).Get<ApplicationSignInManager>( );
			}
			private set
			{
				_signInManager = value;
			}
		}

		public ApplicationUserManager UserManager
		{
			get
			{
				return _userManager ?? HttpContext.GetOwinContext( ).GetUserManager<ApplicationUserManager>( );
			}
			private set
			{
				_userManager = value;
			}
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