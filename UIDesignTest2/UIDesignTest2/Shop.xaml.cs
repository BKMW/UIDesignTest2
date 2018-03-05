using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace UIDesignTest2
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Shop : ContentPage
	{
		public Shop ()
		{
			InitializeComponent ();
		    ListProducts.ItemsSource = new List<Product>
		    {
		        new Product
		        {
		            Designation = "Gucci Hand Bag Light Brown",
		            Status = "Almost New",
		            Price = "3000.00 SAR",
		            Image = "http://lorempixel.com/400/200/sports/"
		        },
		        new Product
		        {
		            Designation = "Gucci Hand Bag Light Brown",
		            Status = "Almost New",
		            Price = "3000.00 SAR",
		            Image = "http://lorempixel.com/400/200/sports/"
		        },
		        new Product
		        {
		            Designation = "Gucci Hand Bag Light Brown",
		            Status = "Almost New",
		            Price = "3000.00 SAR",
		            Image = "http://lorempixel.com/400/200/sports/"
		        }
		    };
		}
	}
}