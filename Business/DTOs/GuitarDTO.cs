using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.DTOs
{
    public class GuitarDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public string Color { get; set; }
        public float Price { get; set; }
        public string? Img { get; set; }
        public int ExtraProdsId { get; set; }
        public string ExtraProdName { get; set; }
    }
}
