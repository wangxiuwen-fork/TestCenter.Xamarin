using System;
using System.Collections.Generic;
using TestCenter.ViewModels;
using Xamarin.Forms;

namespace TestCenter
{
	public partial class TestView : ContentPage
	{
		public TestView (CourseDetailViewModel viewModel)
		{
			InitializeComponent ();

			BindingContext = viewModel;
		}
	}
}
