using System;
using Ninject.Modules;
using WebFormsMvp.Binder;
using Techrepo.Web.App_Start.Factories;
using Ninject.Extensions.Factory;
using WebFormsMvp;
using Ninject.Activation;
using Ninject.Parameters;
using System.Linq;
using Ninject;

namespace Techrepo.Web.App_Start.NinjectModules
{
    public class MvpNinjectModule : NinjectModule
    {
        public override void Load()
        {
            this.Bind<IPresenterFactory>().To<WebFormsMvpPresenterFactory>().InSingletonScope();
            this.Bind<ICustomPresenterFactory>().ToFactory().InSingletonScope();
            this.Bind<IPresenter>().ToMethod(this.GetPresenter).NamedLikeFactoryMethod((ICustomPresenterFactory factory) => factory.GetPresenter(null, null));
        }

        private IPresenter GetPresenter(IContext context)
        {
            var parameters = context.Parameters.ToList();

            var presenterType = (Type)parameters[0].GetValue(context, null);
            var viewInstance = (IView)parameters[1].GetValue(context, null);

            var ctorParamter = new ConstructorArgument("view", viewInstance);

            return (IPresenter)context.Kernel.Get(presenterType, ctorParamter);
        }
    }
}