using Microsoft.AspNetCore.Mvc.Razor;

namespace EpiSvelte.Extensions;

public class ViewLocationExpander : IViewLocationExpander
{
    public void PopulateValues(ViewLocationExpanderContext context)
    {
        // Don't need anything here, but required by the interface
    }

    public IEnumerable<string> ExpandViewLocations(ViewLocationExpanderContext context, IEnumerable<string> viewLocations)
    {
        // The old locations are /Views/{1}/{0}.cshtml and /Views/Shared/{0}.cshtml where {1} is the controller and {0} is the name of the View
        // Replace /Views with /Features
        return new string[] {
                "/Features/MVC/{0}.cshtml",
                "/Features/MVC/Partials/{0}.cshtml",
                "/Views/Shared/Partials/{0}.cshtml",
                "/Features/Episerver/Components/{1}/{0}.cshtml",
                "/Features/Episerver/Pages/{1}/{0}.cshtml"
                }.Concat(viewLocations);
    }
}