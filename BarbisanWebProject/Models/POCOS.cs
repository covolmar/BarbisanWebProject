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

	public class Order
	{
		public int Id { get; set; }
		public ApplicationUser ApplicationUser { get; set; }
		public ICollection<OrderItem> OrderItems { get; set; }
	}


	public class OrderItem
	{
		public int Id { get; set; }
		public Order Order { get; set; }
		public Schalungselement Schalungselement { get; set; }
		public int Anzahl { get; set; }
	}


}