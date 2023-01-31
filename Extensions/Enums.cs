namespace EpiSvelte.Extensions
{
    public class Enums
    {
		public enum LazyLoadType
		{
			None,
			Custom,
			CustomProgressive,
			[Obsolete("Use \"Custom\" instead.")]
			Regular = Custom,
			[Obsolete("Use \"CustomProgressive\" instead.")]
			Progressive = CustomProgressive,
			Native,
			Hybrid
		}

		public enum ImageDecoding
		{
			Async,
			Sync,
			Auto,
			None
		}
	}
}
