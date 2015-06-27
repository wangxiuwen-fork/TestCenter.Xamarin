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
            // service registration
#if DEBUG
            builder.RegisterType<TestCenterViewFactory>()
                .As<ViewFactory>()
                .SingleInstance();
#endif
            builder.RegisterType<Navigator>()
                .As<INavigator>()
                .SingleInstance();

            // navigation registration
            builder.Register<INavigation>(context => App.Current.MainPage.Navigation)
                .SingleInstance();
        }
    }
}
