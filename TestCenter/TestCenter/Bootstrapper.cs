using Autofac;
using TestCenter.Bootstrapping;
using TestCenter.ViewModels;
using TestCenter.Views;
using Xamarin.Forms;

namespace TestCenter
{
    public class Bootstrapper : AutofacBootstrapper
    {
        private readonly App _application;

        public Bootstrapper(App application)
        {
            _application = application;
        }

        protected override void ConfigureContainer(ContainerBuilder builder)
        {
            base.ConfigureContainer(builder);
            builder.RegisterModule<TestCenterModule>();
        }

        protected override void RegisterViews(IViewFactory viewFactory)
        {
            viewFactory.Register<CoursesViewModel, CoursesView>();
            viewFactory.Register<CourseViewModel, CourseDetailsView>();
        }

        protected override void ConfigureApplication(IContainer container)
        {
            // set main page
            var viewFactory = container.Resolve<IViewFactory>();
            var mainPage = viewFactory.Resolve<CoursesViewModel>();
            var navigationPage = new NavigationPage(mainPage);

            _application.MainPage = navigationPage;
        }
    }
}
