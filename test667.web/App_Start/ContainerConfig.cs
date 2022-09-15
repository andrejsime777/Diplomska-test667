using Autofac;
using Autofac.Integration.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using test667.data.Services;

namespace test667.web
{
    public class ContainerConfig
    {
        internal static void RegisterContainer()
        {
            var builder = new ContainerBuilder();

            builder.RegisterControllers(typeof(MvcApplication).Assembly);
            builder.RegisterType<SqlProizvodData>()
                .As<IProizvodData>()
                .InstancePerRequest();

            builder.RegisterType<SqlProgramData>()
                .As<IProgramData>()
                .InstancePerRequest();

            builder.RegisterType<SqlKategorijaProgramiData>()
                .As<IKategorijaProgramiData>()
                .InstancePerRequest();

            builder.RegisterType<SqlBrzLinkData>()
                .As<IBrzLinkData>()
                .InstancePerRequest();

            builder.RegisterType<test667DbContext>().InstancePerRequest();






/*
            builder.RegisterType<InMemoryBrzLinkData>()
                .As<IBrzLinkData>()
                .SingleInstance();

            builder.RegisterType<InMemoryProizvodData>()
                .As<IProizvodData>()
                .SingleInstance();

            builder.RegisterType<InMemoryProgramData>()
                .As<IProgramData>()
                .SingleInstance();

            builder.RegisterType<InMemoryKategorijaProgramiData>()
                .As<IKategorijaProgramiData>()
                .SingleInstance();*/

            var container = builder.Build();
            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));
        }
    }
}