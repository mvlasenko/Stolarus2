using System;
using System.Web.ModelBinding;

namespace Stolarus2.Admin.Attributes
{
    public class IncludeListAttribute : Attribute, IMetadataAware
    {
        public void OnMetadataCreated(ModelMetadata metadata)
        {
            metadata.AdditionalValues["IncludeList"] = true;
        }
    }
}