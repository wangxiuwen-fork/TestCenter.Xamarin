using TestCenter.ViewModels;
using Xamarin.Forms;

namespace TestCenter
{
    public partial class QuestionView : ContentPage
    {
        public QuestionView(TestViewModel viewModel)
        {
            InitializeComponent();

            BindingContext = viewModel;
        }
    }
}