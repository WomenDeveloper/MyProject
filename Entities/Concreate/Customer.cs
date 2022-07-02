using System;
using Core.Entities;

namespace Entities.Concreate
{
    public class Customer : IEntity
    {
        public string  CustomerId { get; set; }
        public string ContacName { get; set; }
        public string CompanyName { get; set; }
        public string  City { get; set; }
        public Customer()
        {
        }
    }
}

