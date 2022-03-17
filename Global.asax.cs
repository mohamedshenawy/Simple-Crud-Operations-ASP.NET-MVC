using Crud_Operations.App_Start;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Crud_Operations
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            IOCRegistration.RegisterIOC();
            RouteConfig.RegisterRoutes(RouteTable.Routes);
        }
    }
}
