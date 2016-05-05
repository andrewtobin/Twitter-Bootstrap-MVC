using System;
using System.Linq.Expressions;
using System.Web.Mvc;
using System.Web.Mvc.Html;

namespace Twitter.Bootstrap.Utils.Extensions
{
    public static class BootstrapValidationExtensions
    {        
        public static MvcHtmlString BootstrapValidationMessageFor<TModel, TProperty>(this HtmlHelper<TModel> html, Expression<Func<TModel, TProperty>> expression)
        {
            return html.ValidationMessageFor(expression, null, new { @class = "help-inline" });
        }
    } 
}