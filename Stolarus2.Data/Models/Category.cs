using Stolarus2.Admin.Attributes;
using Stolarus2.Data.Contracts;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.Script.Serialization;

namespace Stolarus2.Data.Models
{
    public class Category : IEntity<int>
    {
        //public Category()
        //{
        //    this.Products = new List<Product>();
        //}

        [ScaffoldColumn(false)]
        public int Id { get; set; }

        [IncludeList()]
        public string Title { get; set; }

        [IncludeList()]
        public string Description { get; set; }

        [IncludeList()]
        public string ImagePath { get; set; }

        //[ScaffoldColumn(false)]
        //[ScriptIgnore(ApplyToOverrides = true)]
        //public virtual ICollection<Product> Products { get; set; }
    }
}
