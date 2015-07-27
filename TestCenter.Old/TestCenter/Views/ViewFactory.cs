using System;
using TestCenter.ViewModels;
using Xamarin.Forms;

namespace TestCenter.Views
{
    public interface ViewFactory
    {
        void Register<TViewModel, TView>()
            where TViewModel : class, ViewModel
            where TView : Page;

        Page Resolve<TViewModel>(Action<TViewModel> setStateAction = null)
            where TViewModel : class, ViewModel;

        Page Resolve<TViewModel>(out TViewModel viewModel, Action<TViewModel> setStateAction = null)
            where TViewModel : class, ViewModel;

        Page Resolve<TViewModel>(TViewModel viewModel)
            where TViewModel : class, ViewModel;
    }
}
