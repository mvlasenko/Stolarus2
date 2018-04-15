using System;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;
using System.Web.Script.Serialization;
using System.Xml.Serialization;
using Stolarus2.Admin.Attributes;
using Stolarus2.Data.Contracts;

namespace Stolarus2.Data.Models
{
    public class Article : IEntity<int>
    {
        [ScaffoldColumn(false)]
        public int Id { get; set; }

        [Display(Name = "Category")]
        [UIHint("_ArticleCategory")]
        public int? ArticleCategoryId { get; set; }

        [ScaffoldColumn(false)]
        [IncludeList("Category")]
        public string ArticleCategoryName
        {
            get
            {
                if (this.ArticleCategory == null)
                    return String.Empty;

                return string.Format("{0}", this.ArticleCategory.Name);
            }
        }

        [ScaffoldColumn(false)]
        [ScriptIgnore(ApplyToOverrides = true)]
        [XmlIgnore]
        public virtual ArticleCategory ArticleCategory { get; set; }

        [IncludeList()]
        public string Name { get; set; }

        [IncludeList("Image")]
        [Display(Name = "Image")]
        [UIHint("_Image")]
        public string ImageURL { get; set; }

        [UIHint("MultilineText")]
        public string Description { get; set; }

        [UIHint("MultilineText")]
        public string Body { get; set; }

        [IncludeList("Created")]
        [Display(Name = "Created")]
        [HiddenInput(DisplayValue = false)]
        public DateTime CreatedDateTime { get; set; }

        [IncludeList("")]
        [ScaffoldColumn(false)]
        public int? SeqID { get; set; }

    }
}