using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryExample
{
    class Factory1 : IAbstractFactory
    {
        public ProductA CreateProductA()
        {
            Console.WriteLine("Factory1: Creating a ProductA1 object.");
            return new ProductA1();
        }

        public ProductB CreateProductB()
        {
            Console.WriteLine("Factory1: Creating a ProductB1 object");
            return new ProductB1();
        }
    }
}
