using EPiServer.Web.Routing;
using EpiSvelte.Interfaces.Backend;
using EpiSvelte.Features.ViewFeatures;
using Microsoft.AspNetCore.Mvc;

namespace EpiSvelte.Features.ViewComponents.MVC;

public class HeaderViewComponent : ViewComponent
{
    private IMenuService _menu;
    private IPageRouteHelper _pageRouteHelper;
    private IContentRepository _contentRepository;

    public HeaderViewComponent(
            IMenuService menu,
            IPageRouteHelper pageRouteHelper,
            IContentRepository contentRepository)
    {
        _menu = menu;
        _pageRouteHelper = pageRouteHelper;
        _contentRepository = contentRepository;
    }

    public async Task<IViewComponentResult> InvokeAsync()
    {
        var pageReference = _pageRouteHelper.PageLink;
        var page = _contentRepository.Get<PageData>(pageReference);

        var header = new HeaderViewModel
        {
            MenuItems = _menu.Menus,
        };

        return View(header);
    }
}