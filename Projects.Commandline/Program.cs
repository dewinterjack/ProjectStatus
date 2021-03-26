using System;
using Autofac;
using Autofac.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection;

namespace Projects.Commandline
{
    internal static class Program
    {
        private static IServiceProvider _serviceProvider;

        private static void Main()
        {
            RegisterServices();
            var service = _serviceProvider.GetService<IProjectService>();
            DisposeServices();
        }

        private static void DisposeServices()
        {
            if (_serviceProvider == null)
            {
                return;
            }

            if (_serviceProvider is IDisposable disposable)
            {
                disposable.Dispose();
            }
        }

        private static void RegisterServices()
        {
            // ReSharper disable once CollectionNeverUpdated.Local
            var collection = new ServiceCollection();
            var builder = new ContainerBuilder();

            builder.RegisterType<ProjectService>().As<IProjectService>();
            
            builder.Populate(collection);

            var appContainer = builder.Build();
            _serviceProvider = new AutofacServiceProvider(appContainer);
        }
    }
}