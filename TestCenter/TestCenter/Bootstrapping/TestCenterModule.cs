using Autofac;
using TestCenter.FakeServices;
using TestCenter.Services;
using TestCenter.ViewModels;
using TestCenter.Views;

namespace TestCenter
{
    public class TestCenterModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            base.Load(builder);

            //Services
            builder.RegisterType<FakeCoursesService>().As<CoursesService>().SingleInstance();
            builder.RegisterType<FakeTestsService>().As<TestsService>().SingleInstance();

            //ViewModel
            builder.RegisterType<CourseViewModel>();
            builder.RegisterType<CoursesViewModel>().SingleInstance();
            builder.RegisterType<TestViewModel>();

            //Views
            builder.RegisterType<CoursesView>().SingleInstance();
            builder.RegisterType<CourseDetailsView>().SingleInstance();
            builder.RegisterType<TestView>().SingleInstance();
        }
    }
}
