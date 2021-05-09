using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Order:IEntity
    {
        public int OrderId { get; set; }
        public int ProductId { get; set; }
        public int ColorId { get; set; }
        public int Amount { get; set; }
        public string CustomPrintPhoto { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
    }
}
