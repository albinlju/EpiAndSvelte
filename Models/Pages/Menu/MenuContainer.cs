namespace EpiSvelte.Models.Pages;

[ContentType(DisplayName = "Menu Container",
    GUID = "4e53646d-e5a4-4404-b01c-12a9a1fccda6",
    Description = "A placeholder to help organise menus",
    GroupName = SystemTabNames.Content)]
[AvailableContentTypes(Include = new[] { typeof(MenuPage) })]
public class MenuContainer : PageData
{
       
}