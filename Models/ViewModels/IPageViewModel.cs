using EpiSvelte.Models.Layout;

namespace EpiSvelte.Model.ViewModels
{
    public interface IPageViewModel<out T> where T : PageData
    {
        T CurrentPage { get; }
        LayoutModel Layout { get; set; }
        IContent Content { get; }
    }
}
