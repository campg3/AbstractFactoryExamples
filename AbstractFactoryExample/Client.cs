using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryExample
{
    class Client
    {
        private ProductA productA;
        private ProductB productB;
        private IAbstractFactory factory;

        public Client(IAbstractFactory factory)
        {
            this.factory = factory;
        }

        public String operation()
        {
            Console.WriteLine("Client : Delegating creating objects to a factory object.");
            productA = factory.CreateProductA();
            productB = factory.CreateProductB();
            return "Hello World from " + productA.getName() + " and " + productB.getName() + "!";
        }
    }
}
