using Autofac;
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
            builder.RegisterType<CourseService>().As<ICourseService>().SingleInstance();

            //ViewModel
            builder.RegisterType<CourseViewModel>();
            builder.RegisterType<CoursesViewModel>().SingleInstance();

            //Views
            builder.RegisterType<CoursesView>().SingleInstance();
            builder.RegisterType<CourseDetailsView>().SingleInstance();
        }
    }
}
