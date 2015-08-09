using System;
using System.ComponentModel;

namespace TestCenter.ViewModels
{
    public interface ViewModel : INotifyPropertyChanged
    {
        string Title { get; set; }

        void SetState<TViewModel>(Action<TViewModel> setStateAction) where TViewModel : class, ViewModel;
    }
}