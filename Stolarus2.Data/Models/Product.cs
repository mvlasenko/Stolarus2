using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.Script.Serialization;
using System.Xml.Serialization;
using Stolarus2.Admin.Attributes;
using Stolarus2.Data.Contracts;

namespace Stolarus2.Data.Models
{
    public class Product : IEntity<int>
    {
        [ScaffoldColumn(false)]
        public int Id { get; set; }

        [IncludeList()]
        public string Name { get; set; }

        public string Description { get; set; }

        public string ShortDescription { get; set; }

        [IncludeList("Image")]
        [Display(Name = "Image")]
        public string ImageURL { get; set; }

        [IncludeList()]
        public decimal Price { get; set; }

        public string Code { get; set; }

        [Display(Name = "Category")]
        public int? CategoryId { get; set; }

        [ScaffoldColumn(false)]
        [IncludeList("ProductCategory")]
        public string ProductCategoryName
        {
            get
            {
                if (this.ProductCategory == null)
                    return String.Empty;

                return string.Format("{0}", this.ProductCategory.Name);
            }
        }

        [ScaffoldColumn(false)]
        [ScriptIgnore(ApplyToOverrides = true)]
        [XmlIgnore]
        public virtual ProductCategory ProductCategory { get; set; }

        [IncludeList("Created")]
        [Display(Name = "Created")]
        public DateTime CreatedDateTime { get; set; }

        [IncludeList()]
        [ScaffoldColumn(false)]
        public int? SeqID { get; set; }

    }
}