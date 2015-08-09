using Autofac;
using TestCenter.Bootstrapping;
using TestCenter.ViewModels;
using TestCenter.Views;
using Xamarin.Forms;

namespace TestCenter
{
    public class Bootstrapper : AutofacBootstrapper
    {
        readonly App TestCenterApp;

        public Bootstrapper(App application)
        {
            TestCenterApp = application;
        }

        protected override void ConfigureContainer(ContainerBuilder builder)
        {
            base.ConfigureContainer(builder);
            builder.RegisterModule<TestCenterModule>();
        }

        protected override void RegisterViewModelForViews(ViewFactory viewFactory)
        {
            viewFactory.Register<InstitutesViewModel, InstitutesView>();
            viewFactory.Register<CoursesViewModel, CoursesView>();
            viewFactory.Register<CourseDetailsViewModel, CourseDetailsView>();
            viewFactory.Register<TestDetailsViewModel, TestDetailsView>();
        }

        protected override void ConfigureApplication(IContainer container)
        {
            var viewFactory = container.Resolve<ViewFactory>();
            var mainPage = viewFactory.Resolve<InstitutesViewModel>();

            TestCenterApp.MainPage = new NavigationPage(mainPage);
        }
    }
}
