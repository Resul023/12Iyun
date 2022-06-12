using MyBiz.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyBiz.ViewModels
{
    public class PortfolioViewModel
    {
        public List<Portfolio> Portfolios { get; set; }
        public List<ProductImage> productImages { get; set; }
    }
}
