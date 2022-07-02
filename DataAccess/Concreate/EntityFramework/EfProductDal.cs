using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using DataAccess.Abstract;
using Entities.Concreate;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Concreate.EntityFramework
{
    public class EfProductDal : IProductDal
    {
        public EfProductDal()
        {
        }

        public void Add(Product entity)
        {
            using (NortwindContext contex = new NortwindContext())
            {
                var addedEntity = contex.Entry(entity);
                addedEntity.State = EntityState.Added;
                contex.SaveChanges();
            }
        }

        public void Delete(Product entity)
        {
            using (NortwindContext contex = new NortwindContext())
            {
                var deletedEntity = contex.Entry(entity);
                deletedEntity.State = EntityState.Deleted;
                contex.SaveChanges();
            }
        }

        public Product Get(Expression<Func<Product, bool>> filter)
        {
            using (NortwindContext contex = new NortwindContext())
            {
                return contex.Set<Product>().SingleOrDefault(filter);
            }
        }

        public List<Product> GetAll(Expression<Func<Product, bool>> filter = null)
        {
            using (NortwindContext contex = new NortwindContext())
            {
                return filter == null
                    ? contex.Set<Product>().ToList()
                    : contex.Set<Product>().Where(filter).ToList();
            }
        }

        public List<Product> GetAllByCategory(int categoryId)
        {
            throw new NotImplementedException();
        }

        public void Update(Product entity)
        {
            using (NortwindContext contex = new NortwindContext())
            {
                var updatedEntity = contex.Entry(entity);
                updatedEntity.State = EntityState.Deleted;
                contex.SaveChanges();
            }
        }
    }
}

