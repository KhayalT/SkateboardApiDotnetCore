using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.DTOs
{
    public class OrderDateDto:IDTO
    {
        public int Id { get; set; }
        public DateTime DeliveryDate { get; set; }
        public DateTime PreparationDate { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
