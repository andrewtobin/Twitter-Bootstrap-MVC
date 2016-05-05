using System.Web.Mvc;
using System.Web.Mvc.Html;
using System.Web.Routing;

namespace Twitter.Bootstrap.Utils.Extensions
{
    public static class BootstrapFormExtensions
    {
        public static MvcForm BootstrapBeginForm(this HtmlHelper html, string cssClass)
        {            
            return html.BeginForm(null, null, new RouteValueDictionary(), FormMethod.Post, HtmlHelper.AnonymousObjectToHtmlAttributes(new { @class = cssClass }));
        }         
    } 
}