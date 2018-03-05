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
	    public List <Product> tempdata;

        public Shop()
	    {
	        InitializeComponent();
	        data();
	        ListProducts.ItemsSource = tempdata;

	    }
	    void data()
	    {

	        tempdata=  new List<Product>
		    {
		        new Product
		        {
		            Designation = "Gucci Hand Bag Light Brown",
		            Status = "Almost New",
		            Price = "3000.00 SAR",
		            Image = "img1.png"
		        },
		        new Product
		        {
		            Designation = "SSSSSSSSSSSSSSSSSSSS",
		            Status = "Almost New",
		            Price = "3000.00 SAR",
		            Image = "img2.png"
                },
		        new Product
		        {
		            Designation = "XXXXXXXXXXXXXXXXXX",
		            Status = "Almost New",
		            Price = "3000.00 SAR",
		            Image = "img3.png"
                }
		    };
		}

	    private void SearchBar_TextChanged(object sender, TextChangedEventArgs e)
	    {
	        //thats all you need to make a search  

	        if (string.IsNullOrEmpty(e.NewTextValue))
	        {
	            ListProducts.ItemsSource = tempdata;
	        }

	        else
	        {
	            ListProducts.ItemsSource = tempdata.Where(x => x.Designation.ToLower().Contains(e.NewTextValue.ToLower()));
	        }
	    }
    }
}