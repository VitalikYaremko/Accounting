using Accounting.Data.Interfaces.Repositories;
using Accounting.Data.Interfaces.Services;
using Accounting.Data.Repositories;
using Accounting.Domain.Services;
using Ninject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http.Dependencies;

namespace Accounting.Infrastructure
{
    public class NinjectDependencyResolver : System.Web.Mvc.IDependencyResolver
    {
        private static IKernel Kernel;
        public NinjectDependencyResolver(IKernel kernelParam)
        {
            Kernel = kernelParam;
            AddBindings();
        }

        private void AddBindings()
        {
            //Base
            //Kernel.Bind<IMapper>().ToMethod(_ => AutoMapperResolver.InitMapper()).InSingletonScope();

            RegisterRepositories();
            RegisterServices();
        }

        private void RegisterRepositories()
        {
            Kernel.Bind<IEmployeeRepository>().To<EmployeeRepository>();
            Kernel.Bind<IPositionRepository>().To<PositionRepository>();

        }

        private void RegisterServices()
        {
            Kernel.Bind<IEmployeeService>().To<EmployeeService>();
            Kernel.Bind<IPositionService>().To<PositionService>();
        }

        public object GetService(Type serviceType)
        {
            return Kernel.TryGet(serviceType);
        }

        public IEnumerable<object> GetServices(Type serviceType)
        {
            return Kernel.GetAll(serviceType);
        }

        public IDependencyScope BeginScope()
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}