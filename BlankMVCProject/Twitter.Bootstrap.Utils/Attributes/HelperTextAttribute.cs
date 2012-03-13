using System;
using System.Web.Mvc;

namespace Twitter.Bootstrap.Utils.Attributes
{
    // Form help text
    public class HelperTextAttribute : Attribute, IMetadataAware
    {
        public string HelperText { get; set; }

        public HelperTextAttribute(string helperText)
        {
            HelperText = helperText;
        }
        
        public void OnMetadataCreated(ModelMetadata metadata)
        {
            metadata.AdditionalValues["helpertext"] = HelperText;
        }
    } 
}