using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.Script.Serialization;
using System.Xml.Serialization;
using Stolarus2.Admin.Attributes;
using Stolarus2.Data.Contracts;

namespace Stolarus2.Data.Models
{
    public class Contact : IEntity<int>
    {
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

        public string Description { get; set; }

        [IncludeList("Created")]
        [Display(Name = "Created")]
        public DateTime CreatedDateTime { get; set; }

        [IncludeList()]
        [ScaffoldColumn(false)]
        public int? SeqID { get; set; }

    }
}