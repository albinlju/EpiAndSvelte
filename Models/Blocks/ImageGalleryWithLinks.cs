using System.ComponentModel.DataAnnotations;
using EPiServer.SpecializedProperties;
using EpiSvelte.Models.Media;

namespace EpiSvelte.Models.Blocks;

[ContentType(DisplayName = "ImageGalleryWithLinks",
   GUID = "60e4e04b-72d5-4641-98ec-c02bf6e0d2a3",
   Description = "Image block")]
public class ImageGalleryWithLinks : BlockData
{
    [MaxOfItem(typeof(ImageFile), itemMax: 3)]
    [UIHint("Image")]
    [Display(Name = "Image", Description = "Add images",
       GroupName = SystemTabNames.Content,
       Order = 10)]
    public virtual IList<ContentReference> Images { get; set; }

    [MaxOfItem(typeof(LinkItem), itemMax: 3)]
    [Display(Name = "Links", Description = "Add links",
       GroupName = SystemTabNames.Content,
       Order = 20)]
    public virtual LinkItemCollection Links { get; set; }
}