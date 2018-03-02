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
	public partial class MasterPage : ContentPage
	{
		public MasterPage ()
		{
			InitializeComponent ();
		    //ListView1.ItemsSource = new string[]
		    //{
		    //    "My acount",
		    //    "Shop",
		    //    "FAQ",
		    //    "Notifications"

		    //};
        }
	}
}