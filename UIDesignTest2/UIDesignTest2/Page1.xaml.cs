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
	public partial class Page1 : MasterDetailPage
	{

		public Page1 ()
		{
			InitializeComponent ();
		    
            ListView1.ItemsSource = new string[]
	        {
	            "My ACCOUNT",
	            "SHOP",
	            "FAQ",
	            "NOTIFICATIONS"

	        };
            Detail=new MyAccount();
	    }

	    private void ListView1_OnItemSelected(object sender, SelectedItemChangedEventArgs e)
	    {
	        if (ListView1.SelectedItem.Equals("My ACCOUNT"))
	        {
                Detail=new MyAccount();
	            IsPresented = false;
	        }
	        else if (ListView1.SelectedItem.Equals("SHOP"))
            {
                Detail = new Shop();
                IsPresented = false;
            }
            else if (ListView1.SelectedItem.Equals("FAQ"))
            {
                Detail = new FAQ();
                IsPresented = false;
            }
	        else
	        {
	            Detail = new Notification();
                IsPresented = false;
            }
	    }
    }
	}
