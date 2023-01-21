using EPiServer.Web.Mvc;
using EpiSvelte.Factories;
using EpiSvelte.Features.Layout;
using EpiSvelte.Model.ViewFeatures;

namespace EpiSvelte.Features.Pages;

public class LandingPageModel : RazorPageModel<LandingPage>, IPageViewModel<LandingPage>
{
    public LandingPage CurrentPage => CurrentContent;

    public LayoutModel Layout { get; set; }
    public IContent Content { get; set; }

    public void OnGet()
    {
        Layout = HttpContext.RequestServices.GetService<PageViewContextFactory>()
            .CreateLayoutModel(CurrentContent.ContentLink, HttpContext);
    }

}