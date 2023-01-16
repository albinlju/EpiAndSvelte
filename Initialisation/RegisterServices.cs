using EPiServer.Framework;
using EPiServer.Framework.Initialization;
using EPiServer.ServiceLocation;
using EpiSvelte.Interfaces.Backend;
using EpiSvelte.Services.Backend;

namespace EpiSvelte.Initialisation;

[ModuleDependency(typeof(ServiceContainerInitialization))]
    public class RegisterServices : IConfigurableModule
    {
        void IInitializableModule.Initialize(InitializationEngine context)
        {
        }

        private void ContextOnInitComplete(object sender, EventArgs e)
        {
        }

        public void ConfigureContainer(ServiceConfigurationContext context)
        {
            context.Services.AddTransient<IMenuService, MenuService>();
        }

        void IInitializableModule.Uninitialize(InitializationEngine context)
        {
        }
    }