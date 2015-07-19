using Autofac;
using TestCenter.Data;
using TestCenter.FakeData;
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

            RegisterDataServices(builder);
            RegisterBusinessServices(builder);
            RegisterViewModels(builder);
            RegisterViews(builder);
        }

        static void RegisterViews(ContainerBuilder builder)
        {
            builder.RegisterType<CoursesView>().SingleInstance();
            builder.RegisterType<CourseDetailsView>().SingleInstance();
        }

        static void RegisterViewModels(ContainerBuilder builder)
        {
            builder.RegisterType<CourseViewModel>();
            builder.RegisterType<CourseDetailsViewModel>();
            builder.RegisterType<CoursesViewModel>().SingleInstance();
        }

        static void RegisterBusinessServices(ContainerBuilder builder)
        {
            builder.RegisterType<FakeCoursesService>().As<CoursesService>().SingleInstance();
            builder.RegisterType<FakeTestsService>().As<TestsService>().SingleInstance();
        }

        static void RegisterDataServices(ContainerBuilder builder)
        {
            builder.RegisterType<FakeCoursesDataService>().As<CoursesDataService>().SingleInstance();
        }
    }
}
