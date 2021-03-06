﻿using Autofac;
using TestCenter.Views;

namespace TestCenter.Bootstrapping
{
    public abstract class AutofacBootstrapper
    {
        public void Run()
        {
            var builder = new ContainerBuilder();

            ConfigureContainer(builder);

            var container = builder.Build();
            var viewFactory = container.Resolve<ViewFactory>();

            RegisterViewModelForViews(viewFactory);

            ConfigureApplication(container);
        }

        protected virtual void ConfigureContainer(ContainerBuilder builder)
        {
            builder.RegisterModule<AutofacModule>();
        }

        protected abstract void RegisterViewModelForViews(ViewFactory viewFactory);

        protected abstract void ConfigureApplication(IContainer container);
    }
}