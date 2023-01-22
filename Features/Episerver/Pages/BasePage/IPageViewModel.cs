using EpiSvelte.Features.Layouts;

namespace EpiSvelte.Model.ViewFeatures
{
    public interface IPageViewModel<out T> where T : PageData
    {
        T CurrentPage { get; }
        LayoutModel Layout { get; set; }
        IContent Content { get; }
    }
}
