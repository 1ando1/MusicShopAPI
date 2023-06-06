using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Music_Shop.Models
{
    public class Guitar
    {
        public int Id { get; set; }
        [Required, MaxLength(250), MinLength(5)]
        public string Name { get; set; }
        [Required, MaxLength(70)]
        public string Type { get; set; }
        [Required]
        public string Color { get; set; }
        [Required]
        public float Price { get; set; }
        public string? ImagePath { get; set; }
        public int ExtraProductsId { get; set; }
        public Data.Models.ExtraProduct? ExtraProduct { get; set; }
    }
}
