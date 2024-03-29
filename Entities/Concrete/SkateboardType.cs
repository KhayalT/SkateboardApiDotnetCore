﻿using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class SkateboardType:IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Skateboard> Skateboards { get; set; }
    }
}
