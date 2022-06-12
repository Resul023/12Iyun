using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MyBiz.Models
{
    public class Position
    {
        public int Id { get; set; }
        [Required]
        [StringLength(maximumLength:60)]
        public string Department { get; set; }
    }
}
