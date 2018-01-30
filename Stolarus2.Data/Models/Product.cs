using Stolarus2.Data.Contracts;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;
using System.Web.Script.Serialization;

namespace Stolarus2.Data.Models
{
    public class Product : IEntity<int>
    {
        [ScaffoldColumn(false)]
        public int Id { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public string ImagePath { get; set; }

        [HiddenInput(DisplayValue = false)]
        public int? CategoryId { get; set; }

        [ScaffoldColumn(false)]
        [ScriptIgnore(ApplyToOverrides = true)]
        public virtual Category Category { get; set; }
    }
}
