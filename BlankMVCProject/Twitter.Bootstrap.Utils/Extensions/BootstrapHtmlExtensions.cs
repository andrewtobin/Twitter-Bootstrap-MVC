using System;
using System.Linq.Expressions;
using System.Web.Mvc;

namespace Twitter.Bootstrap.Utils.Extensions
{
    public static class BootstrapHtmlExtensions
    {        
        public static MvcHtmlString BootstrapFormHelpTextBlock(this HtmlHelper htmlHelper, string helpText)
        {
            return BootstrapFormHelpText(helpText, "help-block");            
        }

        public static MvcHtmlString BootstrapFormHelpTextBlockFor<TModel, TValue>(this HtmlHelper<TModel> html, Expression<Func<TModel, TValue>> expression)
        {
            ModelMetadata metadata = ModelMetadata.FromLambdaExpression(expression, html.ViewData);

            string helpText = GetHelperText(metadata);
                
            return !string.IsNullOrEmpty(helpText) ? html.BootstrapFormHelpTextBlock(helpText) : MvcHtmlString.Empty;                
        }

        public static MvcHtmlString BootstrapFormHelpTextInline(this HtmlHelper htmlHelper, string helpText)
        {
            return BootstrapFormHelpText(helpText, "help-inline");
        }

        public static MvcHtmlString BootstrapFormHelpTextInlineFor<TModel, TValue>(this HtmlHelper<TModel> html, Expression<Func<TModel, TValue>> expression)
        {
            ModelMetadata metadata = ModelMetadata.FromLambdaExpression(expression, html.ViewData);

            string helpText = GetHelperText(metadata);

            return !string.IsNullOrEmpty(helpText) ? html.BootstrapFormHelpTextInline(helpText) : MvcHtmlString.Empty;
        }

        private static string GetHelperText(ModelMetadata metadata)
        {
            string helpText = null;

            if (metadata.AdditionalValues.ContainsKey("helpertext"))
                helpText = metadata.AdditionalValues["helpertext"] as string;

            return helpText;
        }

        private static MvcHtmlString BootstrapFormHelpText(string helpText, string cssClass)
        {
            var p = new TagBuilder("p");
            p.AddCssClass(cssClass);
            p.InnerHtml = helpText;

            return MvcHtmlString.Create(p.ToString());
        }
    }

}