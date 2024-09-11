using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhiteLagoon.Domain.Entities
{
    public class Villa
    {
        public int Id { get; set; }
        [MaxLength(50)]
        public required string Name { get; set; }
        public string? Descrition { get; set; }
        [Range(10,1000)]
        public double Price { get; set; }
        [Display(Name="Price Per Night")]
        [Range(1,10)]
        public int Sqft { get; set; }
        public int Occupancy { get; set; }
        [Display(Name = "Image Url")]
        public string? Imageurl { get; set; }
        public DateTime? CreateDate { get; set; }
        public DateTime? UpdateDate { get; set; }
    }
}