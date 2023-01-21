using EPiServer.Web.Mvc;
using EpiSvelte.Factories;
using EpiSvelte.Features.Layout;
using EpiSvelte.Model.ViewFeatures;

namespace EpiSvelte.Features.Pages;

public class HomePageModel : RazorPageModel<HomePage>, IPageViewModel<HomePage>
{
    public HomePage CurrentPage => CurrentContent;

    public LayoutModel Layout { get; set; }
    public IContent Content { get; set; }

    public void OnGet()
    {
        Layout = HttpContext.RequestServices.GetService<PageViewContextFactory>()
            .CreateLayoutModel(CurrentContent.ContentLink, HttpContext);
    }

}