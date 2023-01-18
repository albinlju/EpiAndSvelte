using EPiServer.Web.Mvc;
using EpiSvelte.Models.Blocks;
using Microsoft.AspNetCore.Mvc;

namespace EpiSvelte.Models.ViewComponents;

public class ImageGalleryWithLinksViewComponent : BlockComponent<ImageGalleryWithLinks>
{
    protected override IViewComponentResult InvokeComponent(ImageGalleryWithLinks currentBlock)
    {
        return View(currentBlock);
    }
}