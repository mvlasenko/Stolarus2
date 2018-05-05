using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;
using System.Web.Script.Serialization;
using System.Xml.Serialization;
using Stolarus2.Admin.Attributes;
using Stolarus2.Data.Contracts;

namespace Stolarus2.Data.Models
{
    public class Portfolio : IEntity<int>
    {
        public Portfolio()
        {
            this.PortfolioDetails = new List<PortfolioDetail>();
        }

        [ScaffoldColumn(false)]
        public int Id { get; set; }

        [Display(Name = "Portfolio Type")]
        [UIHint("_PortfolioType")]
        public int? PortfolioTypeId { get; set; }

        [ScaffoldColumn(false)]
        [IncludeList("PortfolioType")]
        public string PortfolioTypeName
        {
            get
            {
                if (this.PortfolioType == null)
                    return String.Empty;

                return string.Format("{0}", this.PortfolioType.Name);
            }
        }

        [ScaffoldColumn(false)]
        [ScriptIgnore(ApplyToOverrides = true)]
        [XmlIgnore]
        public virtual PortfolioType PortfolioType { get; set; }

        [IncludeList()]
        public string Name { get; set; }

        [UIHint("MultilineText")]
        public string Description { get; set; }

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

        [ScaffoldColumn(false)]
        [ScriptIgnore(ApplyToOverrides = true)]
        [XmlIgnore]
        public virtual ICollection<PortfolioDetail> PortfolioDetails { get; set; }

    }
}