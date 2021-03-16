using System;

namespace AbstractFactoryExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Client client = new Client(new Factory1());

            Console.WriteLine(client.operation());
        }
    }
}
