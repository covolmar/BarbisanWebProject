using BarbisanWebProject.Models;
using Microsoft.Owin;
using Owin;
using System.Collections.Generic;

[assembly: OwinStartupAttribute(typeof(BarbisanWebProject.Startup))]
namespace BarbisanWebProject
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);


#if DEBUG
			var schalungselement270X240 = new Schalungselement( )
			{
				Id = 1,
				Artikelnummer = 271,
				Name = "Peri Trio",
				Bezeichnung = "Trio-Element TR 270 x 240",
				Preis = 60
			};

			var schalungselement270x120 = new Schalungselement( )
			{
				Id = 2,
				Artikelnummer = 272,
				Name = "Peri Trio",
				Bezeichnung = "Trio-Element TR 270 x 120",
				Preis = 120
			};

			var schalungselement270x90 = new Schalungselement( )
			{
				Id = 3,
				Artikelnummer = 273,
				Name = "Peri Trio",
				Bezeichnung = "Trio-Element TR 270 x 90",
				Preis = 180
			};

			var elementList = new List<Schalungselement>( );
			elementList.Add( schalungselement270x120 );
			elementList.Add( schalungselement270X240 );
			elementList.Add( schalungselement270x90 );

			using( var ctx = new ApplicationDbContext( ) )
			{
				ctx.Schalungselemente.AddRange( elementList );
				ctx.SaveChanges( );
			}
#endif


		}

    }
}
