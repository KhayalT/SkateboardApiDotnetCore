using Core.Entities;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.DTOs
{
    public class SkateboardDetailsDto:IDTO
    {
        public int SkateboardId { get; set; }
        public string SkateboardName { get; set; }
        public decimal Price { get; set; }
        public decimal PrintPrice { get; set; }
        public string SkateboardType { get; set; }
        public List<string> Colors { get; set; }
    }
}
