using Autofac;
using Autofac.Integration.Mvc;
using Crud_Operations.DataBaseContexts;
using Crud_Operations.OperationsRepo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Crud_Operations.App_Start
{
    public class IOCRegistration
    {
        public static void RegisterIOC()
        {
            var builder = new ContainerBuilder();
            builder.RegisterControllers(typeof(MvcApplication).Assembly);
            builder.RegisterType<StudentRepo>().As<IStudentRepo>().SingleInstance();
            builder.RegisterType<MogoContext>().As<IContext>().SingleInstance();
            IContainer container = builder.Build();
            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));
        }
    }
}