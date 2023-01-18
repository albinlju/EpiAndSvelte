using EPiServer.Web.Mvc;
using EpiSvelte.Factories;
using EpiSvelte.Models.Layout;
using EpiSvelte.Model.ViewModels;

namespace EpiSvelte.Models.Pages;

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