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

            //Data Services
            builder.RegisterType<FakeCoursesDataService>().As<CoursesDataService>().SingleInstance();

            //Services
            builder.RegisterType<FakeCoursesService>().As<CoursesService>().SingleInstance();
            builder.RegisterType<FakeTestsService>().As<TestsService>().SingleInstance();

            //ViewModel
            builder.RegisterType<CourseViewModel>();
            builder.RegisterType<CourseDetailsViewModel>();
            builder.RegisterType<CoursesViewModel>().SingleInstance();

            //Views
            builder.RegisterType<CoursesView>().SingleInstance();
            builder.RegisterType<CourseDetailsView>().SingleInstance();
        }
    }
}
