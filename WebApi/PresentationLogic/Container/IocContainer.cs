using System.Web.Mvc;
using Castle.Windsor;
using Castle.Windsor.Installer;

namespace WebApi.PresentationLogic.Container
{
    public static class IocContainer
    {
        private static IWindsorContainer _container;

        public static void Setup()
        {
            _container = new WindsorContainer().Install(FromAssembly.This());

            var controllerFactory = new WindsorControllerFactory(_container.Kernel);
            ControllerBuilder.Current.SetControllerFactory(controllerFactory);
        }

        public static void Dispose()
        {
            _container.Dispose();
        }
    }
}