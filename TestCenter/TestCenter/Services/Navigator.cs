using System;
using System.Threading.Tasks;
using TestCenter.ViewModels;

namespace TestCenter.Services
{
    public interface Navigator
    {
        Task<ViewModel> PopAsync();

        Task<ViewModel> PopModalAsync();

        Task PopToRootAsync();

        Task<TViewModel> PushAsync<TViewModel>(Action<TViewModel> setStateAction = null)
            where TViewModel : class, ViewModel;

        Task<TViewModel> PushAsync<TViewModel>(TViewModel viewModel)
            where TViewModel : class, ViewModel;

        Task<TViewModel> PushModalAsync<TViewModel>(Action<TViewModel> setStateAction = null)
            where TViewModel : class, ViewModel;

        Task<TViewModel> PushModalAsync<TViewModel>(TViewModel viewModel)
            where TViewModel : class, ViewModel;
    }
}