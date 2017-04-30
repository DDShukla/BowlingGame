[assembly: WebActivator.PostApplicationStartMethod(typeof(Bowling.WebAPI.App_Start.SimpleInjectorWebApiInitializer), "Initialize")]

namespace Bowling.WebAPI.App_Start
{
    using SimpleInjector;
    using SimpleInjector.Integration.WebApi;
    using System.Web.Http;

    public static class SimpleInjectorWebApiInitializer
    {
        /// <summary>Initialize the container and register it as Web API Dependency Resolver.</summary>
        public static void Initialize()
        {
            var container = new Container();
            container.Options.DefaultScopedLifestyle = new WebApiRequestLifestyle();

            InitializeContainer(container);

            container.RegisterWebApiControllers(GlobalConfiguration.Configuration);

            container.Verify();

            GlobalConfiguration.Configuration.DependencyResolver =
                new SimpleInjectorWebApiDependencyResolver(container);
        }

        private static void InitializeContainer(Container container)
        {
            Bowling.LogicLayer.Bootstrapper.Setup(container);

        }
    }
}