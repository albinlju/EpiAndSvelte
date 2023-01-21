using EPiServer.Web.Mvc;
using EpiSvelte.Features.Blocks;
using Microsoft.AspNetCore.Mvc;

namespace EpiSvelte.Features.ViewComponents;

public class TabBlockViewComponent : BlockComponent<TabBlock>
{
    protected override IViewComponentResult InvokeComponent(TabBlock currentBlock)
    {
        return View(currentBlock);
    }
}