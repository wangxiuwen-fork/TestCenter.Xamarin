using TestCenter.ViewModels;
using Xamarin.Forms;

namespace TestCenter
{
    public partial class InstitutesView : ContentPage
	{
		public InstitutesView (InstitutesViewModel viewModel)
		{
			InitializeComponent ();

            BindingContext = viewModel;
		}
	}
}
