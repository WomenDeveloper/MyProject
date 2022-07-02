using System;
using Core.Entities;

namespace Entities.Concreate
{
    public class Order : IEntity
    {
        public int  OrderId { get; set; }
        public string CustomerId { get; set; }
        public int EmployeeId { get; set; }
        public DateTime OrderDate { get; set; }
        public string ShipCity { get; set; }
    }
}

