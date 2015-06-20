using System;
using System.ComponentModel;

namespace TestCenter.ViewModels
{
    public interface IViewModel : INotifyPropertyChanged
    {
        string Title { get; set; }

        void SetState<TViewModel>(Action<TViewModel> setStateAction) where TViewModel : class, IViewModel;
    }
}
