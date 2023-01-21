using EPiServer.Web.Mvc;
using EpiSvelte.Features.Blocks;
using Microsoft.AspNetCore.Mvc;

namespace EpiSvelte.Features.ViewComponents;

public class ImageGalleryWithLinksViewComponent : BlockComponent<ImageGalleryWithLinks>
{
    protected override IViewComponentResult InvokeComponent(ImageGalleryWithLinks currentBlock)
    {
        return View(currentBlock);
    }
}