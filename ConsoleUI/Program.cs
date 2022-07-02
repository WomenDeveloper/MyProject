// See https://aka.ms/new-console-template for more information
using Business.Concreate;
using DataAccess.Concreate.EntityFramework;
using DataAccess.Concreate.InMemory;
using Entities.Concreate;

//ProductManager productManager = new ProductManager(new InMemoryProductDal());
ProductManager productManager = new ProductManager(new EfProductDal());
foreach (Product p in productManager.GetByUnitPrice(2,500))
{
    Console.WriteLine(p.ProductName);
}

