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
            builder.RegisterType<InstitutesView>().SingleInstance();
            builder.RegisterType<CoursesView>().SingleInstance();
            builder.RegisterType<CourseDetailsView>().SingleInstance();
            builder.RegisterType<TestDetailsView>().SingleInstance();
            builder.RegisterType<TestView>().SingleInstance();
        }

        static void RegisterViewModels(ContainerBuilder builder)
        {
            builder.RegisterType<InstitutesViewModel>().SingleInstance();
            builder.RegisterType<InstituteViewModel>();
            builder.RegisterType<CourseViewModel>();
            builder.RegisterType<CourseDetailsViewModel>();
            builder.RegisterType<CoursesViewModel>();
            builder.RegisterType<TestsViewModel>();
            builder.RegisterType<TestsListItemViewModel>();
            builder.RegisterType<TestDetailsViewModel>();
            builder.RegisterType<TestViewModel>();
        }

        static void RegisterBusinessServices(ContainerBuilder builder)
        {
            builder.RegisterType<FakeInstituteService>().As<InstituteService>().SingleInstance();
            builder.RegisterType<FakeCoursesService>().As<CoursesService>().SingleInstance();
            builder.RegisterType<FakeTestsService>().As<TestsService>().SingleInstance();
        }

        static void RegisterDataServices(ContainerBuilder builder)
        {
            builder.RegisterType<FakeInstituteDataService>().As<InstituteDataService>().SingleInstance();
            builder.RegisterType<FakeCoursesDataService>().As<CoursesDataService>().SingleInstance();
            builder.RegisterType<FakeTestsDataService>().As<TestsDataService>().SingleInstance();
        }
    }
}