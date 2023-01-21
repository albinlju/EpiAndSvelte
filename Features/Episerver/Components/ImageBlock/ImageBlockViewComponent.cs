using EPiServer.Web.Mvc;
using EpiSvelte.Features.Blocks;
using Microsoft.AspNetCore.Mvc;

namespace EpiSvelte.Features.ViewComponents;

public class ImageBlockViewComponent : BlockComponent<ImageBlock>
{
    protected override IViewComponentResult InvokeComponent(ImageBlock currentBlock)
    {
        return View(currentBlock);
    }
}