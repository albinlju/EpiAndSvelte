using EpiSvelte.Constants;
using System.ComponentModel.DataAnnotations;

namespace EpiSvelte.Models.Pages;

public class PageBase : PageData
{

    [Display(
        GroupName = SystemTabNames.Content,
        Order = 10)]
    public virtual string Title { get; set; }

    [UIHint("image")]
    [Display(
        GroupName = SystemTabNames.Content,
        Order = 10)]
    public virtual ContentReference TopImage { get; set; }

    [Display(
        GroupName = SystemTabNames.Content,
        Order = 20)]
    public virtual ContentArea Blocks { get; set; }

    [Display(
            Name = "MetaDescrption",
            GroupName = GlobalConstants.TabNames.Seo,
            Order = 200)]
    public virtual string MetaTitle { get; set; }
    [Display(
        Name = "MetaDescrption",
        GroupName = GlobalConstants.TabNames.Seo,
        Order = 210)]
    public virtual string MetaDescription { get; set;}

}

