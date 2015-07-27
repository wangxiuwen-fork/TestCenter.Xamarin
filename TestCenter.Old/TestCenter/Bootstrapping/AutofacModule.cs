using Autofac;
using TestCenter.Services;
using TestCenter.Views;
using Xamarin.Forms;

namespace TestCenter.Bootstrapping
{
    public class AutofacModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<TestCenterViewFactory>()
                .As<ViewFactory>()
                .SingleInstance();

            builder.RegisterType<AppNavigator>()
                .As<Navigator>()
                .SingleInstance();

            builder.Register<INavigation>(context => App.Current.MainPage.Navigation)
                .SingleInstance();
        }
    }
}
