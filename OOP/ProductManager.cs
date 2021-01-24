using System;
using System.Collections.Generic;
using System.Text;

namespace OOP
{
    class ProductManager
    {
        public void Add(Products products)
        {
            Console.WriteLine(products.ProductName + " eklendi.");
        }

        public void Update(Products products)
        {
            Console.WriteLine(products.ProductName + " güncellendi.");
        }
    }
}
