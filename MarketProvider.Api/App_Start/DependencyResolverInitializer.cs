using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Ninject;
using MarketProvider.Domain;
using MarketProvider.Services;
using MarketProvider.Services.Implementations;
using MarketProvider.Domain.Entities;
using MarketProvider.Domain.Repositories;
using Ninject.Syntax;
using System.Web.Http;
using System.Web.Http.Dependencies;

[assembly: WebActivator.PreApplicationStartMethod(typeof(MarketProvider.Api.App_Start.DependencyResolverInitializer), "Initialize")]

namespace MarketProvider.Api.App_Start
{
    public static class DependencyResolverInitializer
    {
        public static void Initialize()
        {
            GlobalConfiguration.Configuration.DependencyResolver = new NinjectDependencyResolver(DependencyResolverInitializer.CreateKernel());
        }

        private static IKernel CreateKernel()
        {
            IKernel kernel = new StandardKernel();
            kernel.Bind<ISportsbookDbContext>().To<SportsbookDbContext>();
            kernel.Bind<IRepository<EventEntity>>().To<Repository<EventEntity>>();
            kernel.Bind<IRepository<CategoryEntity>>().To<Repository<CategoryEntity>>();
            kernel.Bind<IRepository<SubCategoryEntity>>().To<Repository<SubCategoryEntity>>();
            kernel.Bind<IRepository<MarketEntity>>().To<Repository<MarketEntity>>();

            kernel.Bind<IPrematchEventService>().To<PrematchEventService>();
            kernel.Bind<ISubCategoryService>().To<SubCategoryService>();
            kernel.Bind<IPrematchMarketService>().To<PrematchMarketService>();

            kernel.Bind<IMarketNavigationService>().To<MarketNavigationService>()
                .WithConstructorArgument("subCatRepo", c => c.Kernel.Get<IRepository<SubCategoryEntity>>())
                .WithConstructorArgument("marketRepo", c => c.Kernel.Get<IRepository<MarketEntity>>());


            return kernel;
        }
    }

    public class NinjectDependencyResolver : NinjectScope, IDependencyResolver
    {
        public NinjectDependencyResolver(IKernel kernel)
            : base(kernel)
        {
            
        }

        public IDependencyScope BeginScope()
        {
            return new NinjectScope(((IKernel)_kernel).BeginBlock());
        }
       
    }

    public class NinjectScope : IDependencyScope
    {
        protected readonly IResolutionRoot _kernel;

        public NinjectScope(IResolutionRoot kernel)
        {
            _kernel = kernel;
        }

        public object GetService(Type serviceType)
        {
            return _kernel.TryGet(serviceType);
        }

        public IEnumerable<object> GetServices(Type serviceType)
        {
            return _kernel.GetAll(serviceType);
        }

        public void Dispose()
        {
            IDisposable disposable = (IDisposable)_kernel;
            if (disposable != null)
            {
                disposable.Dispose();
                disposable = null;
            }
        }
    }
}