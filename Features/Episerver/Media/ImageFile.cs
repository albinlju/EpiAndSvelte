using EPiServer.Framework.DataAnnotations;

namespace EpiSvelte.Features.Media;

[ContentType(
        DisplayName = "ImageFile",
        GUID = "D3922A4A-2DD2-442E-8CFF-ABF813289F61")]
[MediaDescriptor(ExtensionString = "jpg,jpeg,gif,png")]
public class ImageFile : ImageData
{
}