using EpiSvelte.Interfaces.Backend;
using EpiSvelte.Features.Pages;

namespace EpiSvelte.Services.Backend;

public class MenuService : IMenuService
{
    private IContentRepository _contentRepository;

    public MenuService(
        IContentRepository contentRepository)
    {
        _contentRepository = contentRepository;
    }

    public IEnumerable<MenuItem> Menus => GetMenuItems();

    private IEnumerable<MenuItem> GetMenuItems()
    {
        var container = _contentRepository
            .GetChildren<MenuContainer>(ContentReference.RootPage)
            .FirstOrDefault();

        if (container == null) return Enumerable.Empty<MenuItem>();

        var headerMenu = _contentRepository
            .GetChildren<MenuPage>(container.ContentLink)
            .FirstOrDefault(y => y.Name.ToLower().Contains("main menu"));

        if (headerMenu == null) return Enumerable.Empty<MenuItem>();

        return _contentRepository.GetChildren<MenuItem>(headerMenu.ContentLink);
    }
}