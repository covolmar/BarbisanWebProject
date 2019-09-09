using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BarbisanWebProject.Models
{
    public class Schalungselement
    {

        public int Id { get; set; }
        public int Artikelnummer { get; set; }
        public string Name { get; set; }
        public string Bezeichnung { get; set; }
		public int Preis { get; set; }

	}
}