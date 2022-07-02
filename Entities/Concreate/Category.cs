using System;
using Core.Entities;

namespace Entities.Concreate
{
    public class Category : IEntity
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public Category()
        {
        }
    }
}

