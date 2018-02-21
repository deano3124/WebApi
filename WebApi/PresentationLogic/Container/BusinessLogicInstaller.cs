using Castle.MicroKernel.Registration;
using Castle.MicroKernel.SubSystems.Configuration;
using Castle.Windsor;

using WebApi.Interfaces;
using WebApi.Task;

namespace WebApi.Web.PresentationLogic.Container
{
    public class BusinessLogicInstaller : IWindsorInstaller
    {
        public void Install(IWindsorContainer container, IConfigurationStore store)
        {
            container.Register( Component.For<IDemoTasks>().ImplementedBy<DemoTasks>());

            //container.Register( Classes.FromAssemblyContaining<DemoTasks>()
            //                          .InSameNamespaceAs<DemoTasks>()
            //                          .WithServiceAllInterfaces() );
        }
    }
}