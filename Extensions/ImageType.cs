using Baaijte.Optimizely.ImageSharp.Web;
using static EpiSvelte.Extensions.Enums;

namespace EpiSvelte.Extensions
{
    public class ImageType
    {
		private int? _defaultImgWidth;

		/// <summary>
		/// This size will be used in browsers that don't support the picture element.
		/// Will use the largest SrcSetWidth if not set.
		/// </summary>
		public int? DefaultImgWidth
		{
			get
			{
				if (_defaultImgWidth == default && SrcSetWidths != null)
				{
					return SrcSetWidths.Max();
				}
				return _defaultImgWidth;
			}
			set => _defaultImgWidth = value;
		}

		/// <summary>
		/// The different image widths that the browser will select from.
		/// </summary>
		public int[] SrcSetWidths { get; set; }

		public string[] SrcSetSizes { get; set; }

		public double HeightRatio { get; set; }

		/// <summary>
		/// Default value for quality = 80
		/// </summary>
		public int Quality { get; set; }

		/// <summary>
		/// Create Webp versions for these image formats.
		/// </summary>
		public ImageFormat[] CreateWebpForFormat { get; set; }

		/// <summary>
		/// Create lossless Webp versions for images in png format.
		/// </summary>
		public bool CreateLosslessWebpForPng { get; set; }

		/// <summary>
		/// Img element decoding attribute.
		/// </summary>
		public ImageDecoding ImageDecoding { get; set; }

		public ImageType()
		{
			Quality = 80;
			CreateWebpForFormat = new ImageFormat[] { ImageFormat.Jpg, ImageFormat.Png };
			CreateLosslessWebpForPng = true;
			ImageDecoding = ImageDecoding.Async;
		}
	}
}
