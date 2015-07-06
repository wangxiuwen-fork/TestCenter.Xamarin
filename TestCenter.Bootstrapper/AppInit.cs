using Autofac;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestCenter.Data;
using TestCenter.FakeData;
using TestCenter.FakeServices;
using TestCenter.Services;

namespace TestCenter.Bootstrapper
{
    public class AppInitModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            base.Load(builder);

            //Data Layer
            builder.RegisterType<FakeCoursesDataService>().As<CoursesDataService>().SingleInstance();

            //Services Layer
            builder.RegisterType<FakeCoursesService>().As<CoursesService>().SingleInstance();
            builder.RegisterType<FakeTestsService>().As<TestsService>().SingleInstance();
        }
    }
}
