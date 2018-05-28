using System.ComponentModel.DataAnnotations;
using Stolarus2.Admin.Attributes;
using Stolarus2.Data.Contracts;

namespace Stolarus2.Data.Models
{
    public class Translation : IEntity<int>
    {
        [ScaffoldColumn(false)]
        public int Id { get; set; }

        [IncludeList()]
        [UIHint("_Language")]
        public string Code { get; set; }

        [IncludeList()]
        public string Table { get; set; }

        [IncludeList()]
        public string Field { get; set; }

        [IncludeList()]
        public string Text { get; set; }
    }
}