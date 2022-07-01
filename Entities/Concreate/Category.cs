using System;
using Entities.Abstract;

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

