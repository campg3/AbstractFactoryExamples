using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryExample
{
    interface IAbstractFactory
    {
        ProductA CreateProductA();
        ProductB CreateProductB();
    }
}
