using System;
using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concreate;

namespace DataAccess.Concreate.EntityFramework
{
    public class EfOrderDal : EfEntityRepositoryBase<Order,NorthwindContext>,IOrderDal
    {

    }
}

