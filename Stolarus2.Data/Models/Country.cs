using Stolarus2.Admin.Attributes;
using Stolarus2.Data.Contracts;
using System.ComponentModel.DataAnnotations;

namespace Stolarus2.Data.Models
{
    public class Country : IEntity<int>
    {
        [ScaffoldColumn(false)]
        public int Id { get; set; }

        [IncludeList()]
        public string Name { get; set; }
    }
}
