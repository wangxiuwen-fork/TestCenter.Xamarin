using TestCenter.ViewModels;
using Xamarin.Forms;

namespace TestCenter.Views
{
    public partial class CoursesView : ContentPage
    {
        public CoursesView(CoursesViewModel viewModel)
        {
            InitializeComponent();

            BindingContext = viewModel;
        }
    }
}