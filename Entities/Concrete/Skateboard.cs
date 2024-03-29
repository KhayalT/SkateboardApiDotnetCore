﻿using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Skateboard:IEntity
    {
        public int SkateboardId { get; set; }
        public int TypeId { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public decimal PrintPrice { get; set; }
        public List<SkateboardColor> SkateboardColors { get; set; }

    }
}
