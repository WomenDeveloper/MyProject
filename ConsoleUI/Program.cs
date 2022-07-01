// See https://aka.ms/new-console-template for more information
using Business.Concreate;
using DataAccess.Concreate.InMemory;
using Entities.Concreate;

ProductManager productManager = new ProductManager(new InMemoryProductDal());
foreach (Product p in productManager.GetAll())
{
    Console.WriteLine(p.ProductName);
}

