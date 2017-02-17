using System;
using Ninject.Modules;
using Techrepo.Data;
using Ninject.Web.Common;
using Techrepo.Data.Contracts;
using Techrepo.Web.Account.Views;
using Techrepo.Web.Account.Models;

namespace Techrepo.Web.App_Start.NinjectModules
{
    public class TechrepoNinjectModule : NinjectModule
    {
        public override void Load()
        {
            // TODO: bind presenters and models

            this.Bind<ITechrepoDbContext>().To<TechrepoDbContext>().InRequestScope();
            this.Bind(typeof(IRepository<>)).To(typeof(GenericRepository<>)).InRequestScope();
        }
    }
}