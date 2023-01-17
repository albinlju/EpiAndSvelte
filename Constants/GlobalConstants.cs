using System.ComponentModel.DataAnnotations;

namespace EpiSvelte.Constants
{
    public static class GlobalConstants
    {
        [GroupDefinitions]
        public static class TabNames
        {
            [Display(Order = 100)]
            public const string Container = "Container";

            [Display(Order = 200)]
            public const string Seo = "Seo";
        }
    }
}
