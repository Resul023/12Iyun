using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Http;

namespace MyBiz.Models
{
    public class Sliders
    {
        public int Id { get; set; }
        [StringLength(maximumLength:100)]
        public string Title { get; set; }

        [StringLength(maximumLength: 250)]
        public string Desc { get; set; }

        public string BtnText { get; set; }
        public string BtnUrl { get; set; }
        public int Order { get; set; }
        public string SliderImage { get; set; }
        [NotMapped]
        public IFormFile ImageFile { get; set; }


    }
}
