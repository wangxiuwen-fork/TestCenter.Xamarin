using TestCenter.ViewModels;
using Xamarin.Forms;

namespace TestCenter
{
    public partial class TestView : ContentPage
	{
		public TestView (CourseDetailsViewModel viewModel)
		{
			InitializeComponent ();

			BindingContext = viewModel;
		}
	}
}
