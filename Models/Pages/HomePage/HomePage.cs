using System.ComponentModel.DataAnnotations;

namespace EpiSvelte.Models.Pages;

 [ContentType(
 DisplayName ="Home page",
    GUID = "fe78bb39-39c8-439e-b6c4-5d87d9be1f96",
   GroupName = SystemTabNames.Content)]
public class HomePage : PageData
{
    
      [Display(
         GroupName = SystemTabNames.Content,
         Order = 10)]
      public virtual string Title { get; set; }

      [Display(
         GroupName = SystemTabNames.Content,
         Order = 20)]
      public virtual ContentArea Blocks { get; set; }

}