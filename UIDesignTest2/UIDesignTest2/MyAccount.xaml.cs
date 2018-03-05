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
	public partial class MyAccount : ContentPage
	{
	 

        public MyAccount ()
		{
			InitializeComponent ();
		    
		         ListView2.ItemsSource  =new string[]
		    {
		        "Salwa",
		        "Emna",
		        "Taysir",
		        "Imen",
                "Zaineb"

		    };

		
        }

	    //private void FilterNames()
	    //{
	    //    string filter = SearchFor.Text;
	    //    ListView2.BeginRefresh();
	    //    if (string.IsNullOrWhiteSpace(filter))
	    //    {
	    //        ListView2.ItemsSource = OurList;
	    //    }
	    //    else
	    //    {
	    //        ListView2.ItemsSource = OurList.Where(x => x.ToLower().Contains(filter.ToLower()));
	    //    }
	    //    ListView2.EndRefresh();
	    //}
	    //void OnSearchBarTextChanged(object sender, TextChangedEventArgs args)
	    //{
	    //    FilterNames();
	    //}
	    //void OnSearchBarButtonPressed(object sender, EventArgs args)
	    //{
	    //    FilterNames();
	    //}
    }
   
}