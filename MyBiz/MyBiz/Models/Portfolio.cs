using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MyBiz.Models
{
    public class Portfolio
    {
        public int Id { get; set; }
        [Required]
        [StringLength(maximumLength: 100)]
        public string Category { get; set; }
        public string HoverTitle { get; set; }
        public string ProductTitle1 { get; set; }
        public string Client { get; set; }
        public DateTime ProjectDate { get; set; }
        [Required]
        [StringLength(maximumLength: 250)]
        public string Url { get; set; }
        public string PorjectTitle2 { get; set; }
        [Required]
        [StringLength(maximumLength: 250)]
        public string Desc { get; set; }

        public List<ProductImage> productImage { get; set; } = new List<ProductImage>();

        [NotMapped]
        public IFormFile HoverImage { get; set; }
        [NotMapped]
        public List<IFormFile> DetailImages { get; set; }

    }
}
