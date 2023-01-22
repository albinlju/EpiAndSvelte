using Microsoft.AspNetCore.Html;

namespace EpiSvelte.Features.Layouts
{
    public class LayoutModel
    {
        public bool HideHeader { get; set; }
        public bool HideFooter { get; set; }
        public bool LoggedIn { get; set; }
        public HtmlString LoginUrl { get; set; } = HtmlString.Empty;
        public HtmlString LogOutUrl { get; set; } = HtmlString.Empty;
    }
}
