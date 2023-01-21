using EpiSvelte.Features.Pages;
namespace EpiSvelte.Interfaces.Backend;

public interface IMenuService
{
    IEnumerable<MenuItem> Menus { get; }
}