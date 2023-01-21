using EpiSvelte.Features.Pages;

namespace EpiSvelte.Features.ViewFeatures;

public class HeaderViewModel
{
    public IEnumerable<MenuItem> MenuItems { get; set; } = Enumerable.Empty<MenuItem>();

}