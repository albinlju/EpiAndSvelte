using System.ComponentModel.DataAnnotations;

namespace EpiSvelte.Features.Blocks;

[ContentType(DisplayName = "TabBlock",
   GUID = "0c115949-6a2f-4072-9935-66e31475b633",
   Description = "Tab block")]
public class TabBlock : BlockData
{

    [Display(Name = "Title", Description = "Title for tab container",
        GroupName = SystemTabNames.Content,
        Order = 10)]
    public virtual string Title { get; set; }


    [Display(Name = "Tab 1 text", Description = "Text on first tab button",
       GroupName = SystemTabNames.Content,
       Order = 20)]
    public virtual string TabOneText { get; set; }

    [Display(Name = "Tab 1 description", Description = "Description on first tab",
       GroupName = SystemTabNames.Content,
       Order = 30)]
    public virtual XhtmlString TabOneDescription { get; set; }

    [Display(Name = "Tab 2 text", Description = "Text on second tab button",
      GroupName = SystemTabNames.Content,
      Order = 40)]
    public virtual string TabTwoText { get; set; }

    [Display(Name = "Tab 2 description", Description = "Description on second tab",
       GroupName = SystemTabNames.Content,
       Order = 50)]
    public virtual XhtmlString TabTwoDescription { get; set; }

    [Display(Name = "Tab 3 text", Description = "Text on third tab button",
      GroupName = SystemTabNames.Content,
      Order = 60)]
    public virtual string TabThreeText { get; set; }

    [Display(Name = "Tab 3 description", Description = "Description on third tab",
       GroupName = SystemTabNames.Content,
       Order = 70)]
    public virtual XhtmlString TabThreeDescription { get; set; }
}