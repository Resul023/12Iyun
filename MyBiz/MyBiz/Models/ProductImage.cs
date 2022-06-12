using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyBiz.Models
{
    public class ProductImage
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int PortfolioId { get; set; }
        public Portfolio Portfolio { get; set; }
        public bool? PosterStatus { get; set; }

        
        
    }
}
