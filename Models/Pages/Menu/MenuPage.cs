using System.ComponentModel.DataAnnotations;

namespace EpiSvelte.Models.Pages;

[ContentType(DisplayName = "Menu",
    GUID = "8b977a97-7cfd-4419-935d-37febcd7e7d2",
    Description = "Menu",
    GroupName = SystemTabNames.Content)]
[AvailableContentTypes(Include = new[] { typeof(MenuItem) })]
public class MenuPage : PageData
{
    [CultureSpecific]
    [Display(
        Name = "Menu Url",
        Description = "Menu Url",
        GroupName = SystemTabNames.Content,
        Order = 50)]
    public virtual Url MenuContentPage { get; set; }
}