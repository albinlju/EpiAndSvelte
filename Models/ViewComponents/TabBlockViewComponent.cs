using EPiServer.Web.Mvc;
using EpiSvelte.Models.Blocks;
using Microsoft.AspNetCore.Mvc;

namespace EpiSvelte.Models.ViewComponents;

public class TabBlockViewComponent : BlockComponent<TabBlock>
{
    protected override IViewComponentResult InvokeComponent(TabBlock currentBlock)
    {
        return View(currentBlock);
    }
}