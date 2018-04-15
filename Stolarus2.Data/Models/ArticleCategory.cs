using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;
using System.Web.Script.Serialization;
using System.Xml.Serialization;
using Stolarus2.Admin.Attributes;
using Stolarus2.Data.Contracts;

namespace Stolarus2.Data.Models
{
    public class ArticleCategory : IEntity<int>
    {
        public ArticleCategory()
        {
            this.Article = new List<Article>();
        }

        [ScaffoldColumn(false)]
        public int Id { get; set; }

        [IncludeList()]
        public string Code { get; set; }

        [IncludeList()]
        public string Name { get; set; }

        [IncludeList("Image")]
        [Display(Name = "Image")]
        [UIHint("_Image")]
        public string ImageURL { get; set; }

        [UIHint("MultilineText")]
        public string Description { get; set; }

        [IncludeList("Created")]
        [Display(Name = "Created")]
        [HiddenInput(DisplayValue = false)]
        public DateTime CreatedDateTime { get; set; }

        [IncludeList("")]
        [ScaffoldColumn(false)]
        public int? SeqID { get; set; }

        [ScaffoldColumn(false)]
        [ScriptIgnore(ApplyToOverrides = true)]
        [XmlIgnore]
        public virtual ICollection<Article> Article { get; set; }

    }
}