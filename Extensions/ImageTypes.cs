namespace EpiSvelte.Extensions
{
    public class ImageTypes
    {
        public static ImageType TopHero = new ImageType
        {
            DefaultImgWidth = 1920,
            SrcSetWidths = new[] { 640, 960, 1920 },
            SrcSetSizes = new[] { "100vw" },
            HeightRatio = 0.33
        };
    }
}
