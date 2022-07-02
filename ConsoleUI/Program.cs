// See https://aka.ms/new-console-template for more information
using Business.Concreate;
using DataAccess.Concreate.EntityFramework;
using DataAccess.Concreate.InMemory;
using Entities.Concreate;
using Entities.DTOs;

//ProductManager productManager = new ProductManager(new InMemoryProductDal());
//ProductTest();

//CategoryManager categoryManager = new CategoryManager(new EfCategoryDal());
//foreach (Category c in categoryManager.GetAll())
//{
//    Console.WriteLine(c.CategoryName);
//}

static void ProductTest()
{
    ProductManager productManager = new ProductManager(new EfProductDal());
    foreach (Product p in productManager.GetByUnitPrice(2, 500))
    {
        Console.WriteLine(p.ProductName);
    }
}

ProductManager productManager = new ProductManager(new EfProductDal());
foreach (ProductDetailDto p in productManager.GetProductDetails())
{
    Console.WriteLine(p.ProductName+" / "+ p.CategoryName);
}