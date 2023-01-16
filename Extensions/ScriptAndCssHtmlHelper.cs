using System.Text;
using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using System.Web;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace EpiSvelte.Extensions;

public static class ScriptAndCssHtmlHelper
{
  private const string _jSViewDataName = "RenderJavaScript";
  private const string _styleViewDataName = "RenderStyle";

  public static void AddJavaScript(this IHtmlHelper htmlHelper, string scriptURL)
  {
    List<string> scriptList = htmlHelper.ViewContext.HttpContext
      .Items[ScriptAndCssHtmlHelper._jSViewDataName] as List<string>;
    if (scriptList != null)
    {
      if (!scriptList.Contains(scriptURL))
      {
        scriptList.Add(scriptURL);
      }
    }
    else
    {
      scriptList = new List<string>();
      scriptList.Add(scriptURL);
      htmlHelper.ViewContext.HttpContext
        .Items.Add(ScriptAndCssHtmlHelper._jSViewDataName, scriptList);
    }
  }

  public static IHtmlContent RenderJavaScripts(this IHtmlHelper HtmlHelper)
  {
    StringBuilder result = new StringBuilder();

    List<string> scriptList = HtmlHelper.ViewContext.HttpContext
      .Items[ScriptAndCssHtmlHelper._jSViewDataName] as List<string>;
    if (scriptList != null)
    {
      foreach (string script in scriptList)
      {
        result.AppendLine(string.Format(
          "<script defer src=\"{0}\"></script>", 
          script));
      }
    }
     return new HtmlString(result.ToString());
  }

  public static void AddStyle(this IHtmlHelper htmlHelper, string styleURL)
  {
    List<string> styleList = htmlHelper.ViewContext.HttpContext
      .Items[ScriptAndCssHtmlHelper._styleViewDataName] as List<string>;

   if (styleList != null)
   {
     if (!styleList.Contains(styleURL))
     {
       styleList.Add(styleURL);
     }
   }
   else
   {
     styleList = new List<string>();
     styleList.Add(styleURL);
     htmlHelper.ViewContext.HttpContext
       .Items.Add(ScriptAndCssHtmlHelper._styleViewDataName, styleList);
   }
 }

 public static IHtmlContent RenderStyles(this IHtmlHelper htmlHelper)
 {
   StringBuilder result = new StringBuilder();

   List<string> styleList = htmlHelper.ViewContext.HttpContext
     .Items[ScriptAndCssHtmlHelper._styleViewDataName] as List<string>;

   if (styleList != null)
   {
     foreach (string script in styleList)
     {
       result.AppendLine(string.Format(
         "<link href=\"{0}\" rel=\"stylesheet\" type=\"text/css\" />", 
         script));
     }
   }

  return new HtmlString(result.ToString());
  }
}