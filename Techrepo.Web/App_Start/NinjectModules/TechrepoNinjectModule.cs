﻿using Ninject.Modules;
using Techrepo.Data;
using Ninject.Web.Common;
using Techrepo.Data.Contracts;
using Techrepo.Services;

namespace Techrepo.Web.App_Start.NinjectModules
{
    public class TechrepoNinjectModule : NinjectModule
    {
        public override void Load()
        {
            // TODO: bind presenters and models

            this.Bind<ITechrepoDbContext>().To<TechrepoDbContext>().InRequestScope();
            this.Bind(typeof(IRepository<>)).To(typeof(GenericRepository<>)).InRequestScope();
            this.Bind<IUnitOfWork>().To<UnitOfWork>().InRequestScope();
            this.Bind<IAdvertsService>().To<AdvertsService>().InRequestScope();
            this.Bind<IUserService>().To<UserService>().InRequestScope();
            this.Bind<IAdvertCategoryService>().To<AdvertCategoryService>().InRequestScope();
            this.Bind<ICityService>().To<CityService>().InRequestScope();
        }
    }
}