using Autofac;
using System;
using System.Collections.Generic;
using TestCenter.ViewModels;
using Xamarin.Forms;

namespace TestCenter.Views
{
    public class TestCenterViewFactory : ViewFactory
    {
        readonly IDictionary<Type, Type> ViewMap = new Dictionary<Type, Type>();
        readonly IComponentContext ComponentContext;

        public TestCenterViewFactory(IComponentContext componentContext)
        {
            ComponentContext = componentContext;
        }

        public void Register<TViewModel, TView>()
            where TViewModel : class, ViewModel
            where TView : Page
        {
            ViewMap[typeof(TViewModel)] = typeof(TView);
        }

        public Page Resolve<TViewModel>(Action<TViewModel> setStateAction = null) where TViewModel : class, ViewModel
        {
            TViewModel viewModel;
            return Resolve<TViewModel>(out viewModel, setStateAction);
        }

        public Page Resolve<TViewModel>(out TViewModel viewModel, Action<TViewModel> setStateAction = null)
            where TViewModel : class, ViewModel
        {
            viewModel = ComponentContext.Resolve<TViewModel>();

            var viewType = ViewMap[typeof(TViewModel)];
            var view = ComponentContext.Resolve(viewType) as Page;

            if (setStateAction != null)
                viewModel.SetState(setStateAction);

            view.BindingContext = viewModel;
            return view;
        }

        public Page Resolve<TViewModel>(TViewModel viewModel)
            where TViewModel : class, ViewModel
        {
            var viewType = ViewMap[typeof(TViewModel)];
            var view = ComponentContext.Resolve(viewType) as Page;
            view.BindingContext = viewModel;
            return view;
        }
    }
}
