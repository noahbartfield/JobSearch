using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace JobSearch2._0.Models
{
    public class Job
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public bool Applied { get; set; }
        [Required]
        public bool Rejected { get; set; }
        [Required]
        public bool Interviewed { get; set; }
        [Required]
        public bool OfferRecieved { get; set; }
        [Required]
        public bool Accepted { get; set; }
    }
}
