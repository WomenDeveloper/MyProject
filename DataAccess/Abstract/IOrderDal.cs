using System;
using Core.DataAccess;
using Entities.Concreate;
using System.Collections.Generic;

namespace DataAccess.Abstract
{
    public interface IOrderDal : IEntityRepository<Order>
    {

    }
}

