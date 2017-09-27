using Autofac;
using Autofac.Integration.WebApi;
using Contrucks.Repository.Infrastructure;
using Contrucks.Repository.Repository;
using Contrucks.Service;
using Contrucks.Service.Interfaces;
using System.Linq;
using System.Reflection;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace Contrucks
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            GlobalConfiguration.Configure(WebApiConfig.Register);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);


            // Setup the Container Builder
            var builder = new ContainerBuilder();
            var config = GlobalConfiguration.Configuration;
            builder.RegisterType<UnitOfWork>().As<IUnitOfWork>().InstancePerRequest();

            //Identity Account controller binding using autofac

            builder.RegisterType<UserTablesRepository>().As<IUserTablesRepository>().InstancePerRequest();
            builder.RegisterType<UserTablesService>().As<IUserTablesService>().InstancePerRequest();
            





            builder.RegisterType<DatabaseFactory>().As<IDatabaseFactory>().InstancePerRequest();

            // Register your repositories all at once using assembly scanning
            builder.RegisterAssemblyTypes(typeof(RegistrationRepository).Assembly).Where(t => t.Name.EndsWith("Repository")).AsImplementedInterfaces().InstancePerRequest();

            //builder.RegisterAssemblyTypes(typeof(RegistrationService).Assembly).Where(t => t.Name.EndsWith("Service")).AsImplementedInterfaces().InstancePerRequest();

            builder.RegisterType<RecentJobPostService>().As<IRecentJobPostService>().InstancePerRequest();
            builder.RegisterType<RecentpostsRepository>().As<IRecentpostsRepository>().InstancePerRequest();
            // Register your Web API controllers all at once using assembly scanning
            builder.RegisterApiControllers(Assembly.GetExecutingAssembly());


            // OPTIONAL: Register the Autofac filter provider.
            builder.RegisterWebApiFilterProvider(config);

            // OPTIONAL: Register the Autofac model binder provider.
            builder.RegisterWebApiModelBinderProvider();

            // Set the dependency resolver to be Autofac.
            var container = builder.Build();
            config.DependencyResolver = new AutofacWebApiDependencyResolver(container);
        }
    }
    }

