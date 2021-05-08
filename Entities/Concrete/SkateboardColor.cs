using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class SkateboardColor:IEntity
    {
        public int SkateboardId { get; set; }
        public int ColorId { get; set; }
    }
}
