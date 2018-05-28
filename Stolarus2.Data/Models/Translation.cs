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
        [UIHint("_Enum")]
        public Table Table { get; set; }

        [IncludeList()]
        [UIHint("_Enum")]
        public Field Field { get; set; }

        [IncludeList()]
        public int EntityID { get; set; }

        [IncludeList()]
        [UIHint("MultilineText")]
        public string Text { get; set; }
    }
}