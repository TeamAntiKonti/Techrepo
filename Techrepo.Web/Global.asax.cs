using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Optimization;
using System.Web.Routing;
using System.Web.Security;
using System.Web.SessionState;
using Techrepo.Data;
using Techrepo.Web.App_Start;

namespace Techrepo.Web
{
    public class Global : HttpApplication
    {
        protected void Application_Start(object sender, EventArgs e)
        {
            // Code that runs on application startup
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
            //DbConfig.Initialize();

            //TODO:REMOVE THAT IN PRODUCTION
            //This is here to solve the problem with changing models in db
            //Database.SetInitializer<TechrepoDbContext>(null);

        }
    }
}