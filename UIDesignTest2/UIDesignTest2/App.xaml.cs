using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace UIDesignTest2
{
	public partial class App : Application
	{
		public App ()
		{
			InitializeComponent();
            //MainPage = new UIDesignTest2.MasterPage2();
            MainPage = new NavigationPage(new UIDesignTest2.Page1())
            {
                BarBackgroundColor = Color.FromHex("#514c50")
            };
        }

		protected override void OnStart ()
		{
			// Handle when your app starts
		}

		protected override void OnSleep ()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume ()
		{
			// Handle when your app resumes
		}
	}
}
