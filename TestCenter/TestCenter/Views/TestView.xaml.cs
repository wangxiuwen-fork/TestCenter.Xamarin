using TestCenter.ViewModels;
using Xamarin.Forms;

namespace TestCenter
{
    public partial class TestView : ContentPage
    {
        public TestView(TestViewModel viewModel)
        {
            //InitializeComponent();

            BindingContext = viewModel;
        }
    }
}