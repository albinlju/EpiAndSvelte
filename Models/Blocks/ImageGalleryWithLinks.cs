using System.ComponentModel.DataAnnotations;

namespace EpiSvelte.Models.Blocks;

[ContentType(DisplayName = "Imageblock",
   GUID = "38d57768-e09e-4da9-90df-54c73c61b270",
   Description = "Image block")]
public class ImageGalleryWithLinks : BlockData
{
    [UIHint("Image")]
    [Display(Name = "Image", Description = "Add an image (optional)",
       GroupName = SystemTabNames.Content,
       Order = 10)]
    public virtual IList<ContentReference> Images { get; set; }
}