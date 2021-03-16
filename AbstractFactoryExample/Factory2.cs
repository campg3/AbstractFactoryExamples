using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryExample
{
    class Factory2 : IAbstractFactory
    {
        public ProductA CreateProductA()
        {
            Console.WriteLine("Factory2: Creating a ProductA2 object.");
            return new ProductA2();
        }

        public ProductB CreateProductB()
        {
            Console.WriteLine("Factory2: Creating a ProductB2 object");
            return new ProductB2();
        }
    }
}
