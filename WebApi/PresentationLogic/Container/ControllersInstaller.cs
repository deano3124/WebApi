using System.Web.Mvc;

using Castle.MicroKernel.Registration;
using Castle.MicroKernel.SubSystems.Configuration;
using Castle.Windsor;

using WebApi.Controllers;

namespace MyApp.Web.PresentationLogic.Container
{
    public class ControllersInstaller : IWindsorInstaller
    {
        public void Install(IWindsorContainer container, IConfigurationStore store)
        {
            //container.Register( Classes.FromAssemblyContaining<DemoController>() );
            
            //container.Register(Classes.FromAssemblyContaining<DemoController>()
            //                           .Pick().If(t => t.Name.EndsWith("Controller"))
            //                           .Configure(configurer => configurer.Named(configurer.Implementation.Name))
            //                           .LifestylePerWebRequest());

            container.Register(AllTypes.FromThisAssembly()
                                       .BasedOn<IController>()
                                       .If(t => t.Name.EndsWith("Controller"))
                                       .Configure(configurer => configurer.Named(configurer.Implementation.Name))
                                       .LifestylePerWebRequest());
        }
    }
}