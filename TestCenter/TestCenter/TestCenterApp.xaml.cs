using System;
using System.Collections.Generic;
using TestCenter.Views;
using Xamarin.Forms;

namespace TestCenter
{
	public partial class TestCenterApp : App
	{
		public TestCenterApp ()
		{
            //InitializeComponent ();
            MainPage = new NavigationPage(new MainPage());
		}
	}
}

