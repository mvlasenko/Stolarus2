using Stolarus2.Admin.Attributes;
using Stolarus2.Data.Contracts;
using System.ComponentModel.DataAnnotations;

namespace Stolarus2.Data.Models
{
    public class Language : IEntity<int>
    {
        [ScaffoldColumn(false)]
        public int Id { get; set; }

        [IncludeList()]
        public string Code { get; set; }

        [IncludeList()]
        public string Title { get; set; }
    }
}