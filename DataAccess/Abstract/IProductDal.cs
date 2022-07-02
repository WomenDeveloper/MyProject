using System;
using System.Collections.Generic;
using Core.DataAccess;
using Entities.Concreate;

namespace DataAccess.Abstract
{
    public interface IProductDal : IEntityRepository<Product>
    {

    }
}

