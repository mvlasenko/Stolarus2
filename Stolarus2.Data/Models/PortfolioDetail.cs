using System;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;
using System.Web.Script.Serialization;
using System.Xml.Serialization;
using Stolarus2.Admin.Attributes;
using Stolarus2.Data.Contracts;

namespace Stolarus2.Data.Models
{
    public class PortfolioDetail : IEntity<int>
    {
        [ScaffoldColumn(false)]
        public int Id { get; set; }

        [Display(Name = "Portfolio")]
        [UIHint("_Portfolio")]
        public int PortfolioId { get; set; }

        [ScaffoldColumn(false)]
        [IncludeList("Portfolio")]
        public string PortfolioName
        {
            get
            {
                if (this.Portfolio == null)
                    return String.Empty;

                return string.Format("{0}", this.Portfolio.Name);
            }
        }

        [ScaffoldColumn(false)]
        [ScriptIgnore(ApplyToOverrides = true)]
        [XmlIgnore]
        public virtual Portfolio Portfolio { get; set; }

        [IncludeList()]
        public string Name { get; set; }

        [IncludeList("Image")]
        [Display(Name = "Image")]
        [UIHint("_Image")]
        public string ImageID { get; set; }

        [IncludeList("Created")]
        [Display(Name = "Created")]
        [HiddenInput(DisplayValue = false)]
        public DateTime CreatedDateTime { get; set; }

        [IncludeList("")]
        [ScaffoldColumn(false)]
        public int? SeqID { get; set; }

    }
}