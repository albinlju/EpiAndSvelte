using EPiServer.Data;
using EPiServer.ServiceLocation;
using EPiServer.Web;
using EPiServer.Web.Routing;
using EpiSvelte.Models.Layout;
using EpiSvelte.Models.Pages;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Options;

namespace EpiSvelte.Factories
{
    [ServiceConfiguration]
    public class PageViewContextFactory
    {
        private readonly IContentLoader _contentLoader;
        private readonly UrlResolver _urlResolver;
        private readonly IDatabaseMode _databaseMode;
        private readonly CookieAuthenticationOptions _cookieAuthenticationOptions;

        public PageViewContextFactory(
           IContentLoader contentLoader,
           UrlResolver urlResolver,
           IDatabaseMode databaseMode,
           IOptionsMonitor<CookieAuthenticationOptions> optionMonitor)
        {
            _contentLoader = contentLoader;
            _urlResolver = urlResolver;
            _databaseMode = databaseMode;
            _cookieAuthenticationOptions = optionMonitor.Get(IdentityConstants.ApplicationScheme);
        }

        public virtual LayoutModel CreateLayoutModel(ContentReference currentContentLink, HttpContext httpContext)
        {
            var startPageContentLink = SiteDefinition.Current.StartPage;

            // Use the content link with version information when editing the startpage,
            // otherwise the published version will be used when rendering the props below.
            if (currentContentLink.CompareToIgnoreWorkID(startPageContentLink))
            {
                startPageContentLink = currentContentLink;
            }

            return new LayoutModel
            {
                LoggedIn = httpContext.User.Identity.IsAuthenticated,
                //LoginUrl = new HtmlString(GetLoginUrl(currentContentLink)),
            };
        }

        private string GetLoginUrl(ContentReference returnToContentLink)
        {
            return $"{_cookieAuthenticationOptions?.LoginPath.Value ?? "/util/login"}?ReturnUrl={_urlResolver.GetUrl(returnToContentLink)}";
        }
    }
}
