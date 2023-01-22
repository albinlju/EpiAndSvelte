using EPiServer.Web.Mvc;
using EpiSvelte.Factories;
using EpiSvelte.Features.Layouts;
using EpiSvelte.Model.ViewFeatures;

namespace EpiSvelte.Features.Pages;

public class ClientRenderedModel : RazorPageModel<ClientRendered>, IPageViewModel<ClientRendered>
{
    public ClientRendered CurrentPage => CurrentContent;

    public LayoutModel Layout { get; set; }
    public IContent Content { get; set; }

    public void OnGet()
    {
        Layout = HttpContext.RequestServices.GetService<PageViewContextFactory>()
            .CreateLayoutModel(CurrentContent.ContentLink, HttpContext);
    }

}