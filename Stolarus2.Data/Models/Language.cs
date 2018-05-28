using System.ComponentModel.DataAnnotations;
using Stolarus2.Admin.Attributes;
using Stolarus2.Data.Contracts;

namespace Stolarus2.Data.Models
{
    public class Language : IEntity<int>
    {
        [ScaffoldColumn(false)]
        public int Id { get; set; }

        [IncludeList("Image")]
        [Display(Name = "Image")]
        [UIHint("_Image")]
        public string ImageID { get; set; }

        [IncludeList()]
        public string Name { get; set; }

        [IncludeList()]
        public string Code { get; set; }

        [IncludeList()]
        public bool Default { get; set; }
    }
}