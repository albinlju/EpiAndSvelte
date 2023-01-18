using EPiServer.Web.Mvc;
using EpiSvelte.Models.Blocks;
using Microsoft.AspNetCore.Mvc;

namespace EpiSvelte.Models.ViewComponents;

public class ImageGalleryWithLinksViewComponent : BlockComponent<ImageBlock>
{
    protected override IViewComponentResult InvokeComponent(ImageBlock currentBlock)
    {
        return View(currentBlock);
    }
}