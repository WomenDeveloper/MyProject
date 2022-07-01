using System;
using System.Collections.Generic;
using Entities.Concreate;

namespace Business.Abstract
{
    public interface IProductService
    {
        List<Product> GetAll();
    }
}

