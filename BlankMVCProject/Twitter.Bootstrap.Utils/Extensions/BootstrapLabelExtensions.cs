using System;
using System.Linq.Expressions;
using System.Web.Mvc;

namespace Twitter.Bootstrap.Utils.Extensions
{
    public static class BootstrapLabelExtensions
    {
        public static MvcHtmlString BootstrapLabelFor<TModel, TValue>(this HtmlHelper<TModel> html, Expression<Func<TModel, TValue>> expression)
        {
            return html.LabelFor(expression, new { @class = "control-label" });
        }        
    } 
}