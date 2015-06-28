using System;
using System.Threading.Tasks;
using TestCenter.ViewModels;
using TestCenter.Views;
using Xamarin.Forms;

namespace TestCenter.Services
{
    public class AppNavigator : Navigator
    {
        private readonly Lazy<INavigation> AppNavigation;
        private readonly ViewFactory AppViewFactory;

        public AppNavigator(Lazy<INavigation> navigation, ViewFactory viewFactory)
        {
            AppNavigation = navigation;
            AppViewFactory = viewFactory;
        }

        private INavigation Navigation
        {
            get { return AppNavigation.Value; }
        }

        public async Task<ViewModel> PopAsync()
        {
            Page view = await Navigation.PopAsync();
            return view.BindingContext as ViewModel;
        }

        public async Task<ViewModel> PopModalAsync()
        {
            Page view = await Navigation.PopAsync();
            return view.BindingContext as ViewModel;
        }

        public async Task PopToRootAsync()
        {
            await Navigation.PopToRootAsync();
        }

        public async Task<TViewModel> PushAsync<TViewModel>(Action<TViewModel> setStateAction = null)
            where TViewModel : class, ViewModel
        {
            TViewModel viewModel;
            var view = AppViewFactory.Resolve<TViewModel>(out viewModel, setStateAction);
            await Navigation.PushAsync(view);
            return viewModel;
        }

        public async Task<TViewModel> PushAsync<TViewModel>(TViewModel viewModel)
            where TViewModel : class, ViewModel
        {
            var view = AppViewFactory.Resolve(viewModel);
            await Navigation.PushAsync(view);
            return viewModel;
        }

        public async Task<TViewModel> PushModalAsync<TViewModel>(Action<TViewModel> setStateAction = null)
            where TViewModel : class, ViewModel
        {
            TViewModel viewModel;
            var view = AppViewFactory.Resolve<TViewModel>(out viewModel, setStateAction);
            await Navigation.PushModalAsync(view);
            return viewModel;
        }

        public async Task<TViewModel> PushModalAsync<TViewModel>(TViewModel viewModel)
            where TViewModel : class, ViewModel
        {
            var view = AppViewFactory.Resolve(viewModel);
            await Navigation.PushModalAsync(view);
            return viewModel;
        }
    }
}
