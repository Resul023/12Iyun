using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MyBiz.Models
{
    public class Services
    {
        public int Id { get; set; }
        [Required]
        [StringLength(maximumLength:50)]
        public string Title { get; set; }
        [Required]
        [StringLength(maximumLength: 150)]
        public string Desc { get; set; }
        [Required]
        [StringLength(maximumLength: 250)]
        public string Icon { get; set; }

    }
}
