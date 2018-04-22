using Stolarus2.Data.Models;
using System.Collections.Generic;

namespace Stolarus2.ViewModels
{
    public class SinglePage
    {
        public List<Slider> Sliders { get; set; }

        public List<Article> About { get; set; }

        public List<ProductCategory> ProductCategories { get; set; }

        public List<Portfolio> Portfolios { get; set; }

        public List<Contact> Contacts { get; set; }

    }
}