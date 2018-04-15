using System;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;
using Stolarus2.Admin.Attributes;
using Stolarus2.Data.Contracts;

namespace Stolarus2.Data.Models
{
    public class Slider : IEntity<int>
    {
        [ScaffoldColumn(false)]
        public int Id { get; set; }

        [IncludeList("Image")]
        [Display(Name = "Image")]
        [UIHint("_Image")]
        public string ImageURL { get; set; }

        [IncludeList()]
        public string Name { get; set; }

        [IncludeList("External URL")]
        [Display(Name = "External URL")]
        public string ExternalURL { get; set; }

        [IncludeList("Created")]
        [Display(Name = "Created")]
        [HiddenInput(DisplayValue = false)]
        public DateTime CreatedDateTime { get; set; }

        [IncludeList("")]
        [ScaffoldColumn(false)]
        public int? SeqID { get; set; }

    }
}