using System;
using System.ComponentModel;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;

namespace TestCenter.ViewModels
{
    public class ViewModelBase : IViewModel
    {
        public virtual string Title { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;
        
        public void SetState<TViewModel>(Action<TViewModel> setStateAction) where TViewModel : class, IViewModel
        {
            setStateAction(this as TViewModel);
        }

        protected virtual bool SetProperty<T>(ref T storage, T value, [CallerMemberName] string propertyName = null)
        {
            if (object.Equals(storage, value)) return false;

            storage = value;
            OnPropertyChanged(propertyName);

            return true; 
        }

        private void OnPropertyChanged([CallerMemberName]string propertyName = null)
        {
            var eventHandler = PropertyChanged;
            if (eventHandler != null)
            {
                eventHandler(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        protected void OnPropertyChanged<T>(Expression<Func<T>> propertyExpression)
        {
            var propertyName = PropertySupport.ExtractPropertyName(propertyExpression);
            OnPropertyChanged(propertyName);
        }
    }
}
