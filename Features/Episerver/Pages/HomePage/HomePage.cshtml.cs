using EPiServer.Web.Mvc;
using EpiSvelte.Extensions;
using EpiSvelte.Factories;
using EpiSvelte.Features.Layouts;
using EpiSvelte.Model.ViewFeatures;
using static EpiSvelte.Extensions.Picture;

namespace EpiSvelte.Features.Pages;

public class HomePageModel : RazorPageModel<HomePage>, IPageViewModel<HomePage>
{
    public HomePage CurrentPage => CurrentContent;

    public LayoutModel Layout { get; set; }

    public PictureData Image { get; set; }
    public IContent Content { get; set; }

    public void OnGet()
    {
        //Image = PictureUtils.GetPictureData(CurrentContent.TopImage, ImageTypes.TopHero);
        Layout = HttpContext.RequestServices.GetService<PageViewContextFactory>()
            .CreateLayoutModel(CurrentContent.ContentLink, HttpContext);
    }

}