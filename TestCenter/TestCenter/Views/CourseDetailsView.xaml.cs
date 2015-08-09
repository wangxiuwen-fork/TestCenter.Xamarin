using TestCenter.ViewModels;
using Xamarin.Forms;

namespace TestCenter.Views
{
    public partial class CourseDetailsView : ContentPage
    {
        public CourseDetailsView(CourseDetailsViewModel viewModel)
        {
            InitializeComponent();

            BindingContext = viewModel;
        }
    }
}