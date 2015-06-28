using Autofac;
using TestCenter.Bootstrapping;
using TestCenter.ViewModels;
using TestCenter.Views;
using Xamarin.Forms;

namespace TestCenter
{
    public class Bootstrapper : AutofacBootstrapper
    {
        private readonly App TestCenterApp;

        public Bootstrapper(App application)
        {
            TestCenterApp = application;
        }

        protected override void ConfigureContainer(ContainerBuilder builder)
        {
            base.ConfigureContainer(builder);
            builder.RegisterModule<TestCenterModule>();
        }

        protected override void RegisterViews(ViewFactory viewFactory)
        {
            viewFactory.Register<CoursesViewModel, CoursesView>();
            viewFactory.Register<CourseViewModel, CourseDetailsView>();
        }

        protected override void ConfigureApplication(IContainer container)
        {
            var viewFactory = container.Resolve<ViewFactory>();
            var mainPage = viewFactory.Resolve<CoursesViewModel>();

            TestCenterApp.MainPage = new NavigationPage(mainPage);
        }
    }
}
