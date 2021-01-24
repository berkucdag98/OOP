using System;

namespace OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Products products = new Products { Id = 1,CategoryId=2,ProductName="Masa",UnitPrice = 500,UnitsInStock=3};
            
            //PascalCase   //camelCase
            //case sensitive
            ProductManager productManager = new ProductManager();
            productManager.Add(products);

        }
    }
}
