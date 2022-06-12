using MyBiz.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyBiz.ViewModels
{
    public class HomeViewModel
    {
        public List<Sliders> Sliders { get; set; }
        public List<Services> Services { get; set; }
        public List<Team> Teams { get; set; }
        public List<Portfolio> Portfolios { get; set; }
        public List<PortfolioCategory> PortfolioCategories { get; set; }
        public List<ProductImage> productImages { get; set; }

    }
}
