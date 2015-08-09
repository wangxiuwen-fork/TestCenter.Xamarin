using TestCenter.ViewModels;
using Xamarin.Forms;

namespace TestCenter.Views
{
    public partial class TestDetailsView : ContentPage
    {
        public TestDetailsView(TestDetailsViewModel viewModel)
        {
            InitializeComponent();

            BindingContext = viewModel;
        }
    }
}