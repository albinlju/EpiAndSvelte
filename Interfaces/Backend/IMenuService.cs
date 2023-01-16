using EpiSvelte.Models.Pages;
namespace EpiSvelte.Interfaces.Backend;

public interface IMenuService 
{
    IEnumerable<MenuItem> Menus { get; }
}