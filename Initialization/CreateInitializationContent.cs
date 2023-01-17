using EPiServer.Framework;
using EPiServer.Framework.Initialization;
using EPiServer.Security;
using EPiServer.ServiceLocation;
using EPiServer.Web;
using EpiSvelte.Models.Pages;

namespace EpiSvelte.Initialization
{
    [ModuleDependency(typeof(InitializationModule))]
    public class CreateInitializationContent : IInitializableModule
    {
       

        public void Initialize(InitializationEngine context)
        {
            var root = ContentReference.RootPage;

            IContentRepository contentRepository = ServiceLocator.Current.GetInstance<IContentRepository>();
            CreateHomePageMenuAndSubpages(contentRepository, root);
        }
        public void Uninitialize(InitializationEngine context)
        {
        }

        private void CreateHomePageMenuAndSubpages(IContentRepository repository, PageReference root)
        {
            if (repository.GetChildren<HomePage>(root).FirstOrDefault() == null)
            {
                //Homepage
                PageData homePage = repository.GetDefault<HomePage>(root);
                homePage.Name = "Home Page";
                repository.Save(homePage, EPiServer.DataAccess.SaveAction.Publish, AccessLevel.NoAccess);

                //Landing pages
                PageData aboutPage = repository.GetDefault<LandingPage>(homePage.ContentLink);
                PageData servicesPage = repository.GetDefault<LandingPage>(homePage.ContentLink);
                PageData projectPage = repository.GetDefault<LandingPage>(homePage.ContentLink);

                aboutPage.Name = "About page";
                servicesPage.Name = "Services";
                projectPage.Name = "Projects";

                repository.Save(aboutPage, EPiServer.DataAccess.SaveAction.Publish, AccessLevel.NoAccess);
                repository.Save(servicesPage, EPiServer.DataAccess.SaveAction.Publish, AccessLevel.NoAccess);
                repository.Save(projectPage, EPiServer.DataAccess.SaveAction.Publish, AccessLevel.NoAccess);


                //Menu container
                PageData menuContainer = repository.GetDefault<MenuContainer>(root);
                menuContainer.Name = "Menu container";
                repository.Save(menuContainer, EPiServer.DataAccess.SaveAction.Publish, AccessLevel.NoAccess);

                //Main menu
                PageData mainMenu = repository.GetDefault<MenuPage>(menuContainer.ContentLink);
                mainMenu.Name = "Main menu";
                repository.Save(mainMenu, EPiServer.DataAccess.SaveAction.Publish, AccessLevel.NoAccess);

                //Menu link
                MenuItem aboutPageMenuItem = repository.GetDefault<MenuItem>(mainMenu.ContentLink);
                aboutPageMenuItem.Name = "About page";
                aboutPageMenuItem.MenuUrl = aboutPage != null ? aboutPage.LinkURL : homePage.LinkURL;
                repository.Save(aboutPageMenuItem, EPiServer.DataAccess.SaveAction.Publish, AccessLevel.NoAccess);

                //Menu Link
                MenuItem servicesMenuItem = repository.GetDefault<MenuItem>(mainMenu.ContentLink);
                servicesMenuItem.Name = "Services";
                servicesMenuItem.MenuUrl = servicesPage != null ? servicesPage.LinkURL : homePage.LinkURL;
                repository.Save(servicesMenuItem, EPiServer.DataAccess.SaveAction.Publish, AccessLevel.NoAccess);

                //Menu Link
                MenuItem projectsMenuItem = repository.GetDefault<MenuItem>(mainMenu.ContentLink);
                projectsMenuItem.Name = "Projects";
                projectsMenuItem.MenuUrl = projectPage != null ? projectPage.LinkURL : homePage.LinkURL;
                repository.Save(projectsMenuItem, EPiServer.DataAccess.SaveAction.Publish, AccessLevel.NoAccess);
            }
           
        }
    }
}
