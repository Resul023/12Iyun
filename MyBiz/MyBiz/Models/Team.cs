    using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MyBiz.Models
{
    public class Team
    {
        public int Id { get; set; }
        [Required]
        [StringLength(maximumLength: 100)]
        public string WorkerName { get; set; }
        public string WorkerImage { get; set; }
        public int PositionId { get; set; }
        public Position Position { get; set; }
        public string Desc { get; set; }
        public string FaceUrl { get; set; }
        public string TwitUrl { get; set; }
        public string InstaUrl { get; set; }
        public string linkUrl { get; set; }
        [NotMapped]
        public IFormFile ImageFile { get; set; }
    }
}
