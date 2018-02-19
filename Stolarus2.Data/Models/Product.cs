﻿using System;
using System.ComponentModel.DataAnnotations;
using System.Web.Script.Serialization;
using System.Xml.Serialization;
using Stolarus2.Admin.Attributes;
using Stolarus2.Data.Contracts;
using Stolarus2.Data.Properties;

namespace Stolarus2.Data.Models
{
    public class Product : IEntity<int>
    {
        [ScaffoldColumn(false)]
        public int Id { get; set; }

        [IncludeList()]
        public string Title { get; set; }

        [IncludeList()]
        public string Description { get; set; }

        [Display(Name = "ImagePath", ResourceType = typeof(Resources))]
        [IncludeList("Image")]
        public string ImagePath { get; set; }

        [Display(Name = "CategoryId", ResourceType = typeof(Resources))]
        [UIHint("_Category")]
        public int? CategoryId { get; set; }

        [ScaffoldColumn(false)]
        [IncludeList("Category Name")]
        [ScriptIgnore(ApplyToOverrides = true)]
        [XmlIgnore]
        public string CategoryName
        {
            get
            {
                if (this.Category == null)
                    return String.Empty;

                return string.Format("{0}", this.Category.Title);
            }
        }

        [ScaffoldColumn(false)]
        [ScriptIgnore(ApplyToOverrides = true)]
        [XmlIgnore]
        public virtual Category Category { get; set; }
    }
}