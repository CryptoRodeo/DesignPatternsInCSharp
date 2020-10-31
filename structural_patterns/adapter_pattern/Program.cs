using System;
using adapter_pattern.adaptees;
using adapter_pattern.target_intefaces;
using adapter_pattern.adapter;

namespace adapter_pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Adaptee adaptee = new Adaptee();
            ITarget target = new Adapter(adaptee);

            Console.WriteLine("Adaptee interface is incompatible with the client");
            Console.WriteLine("But with adapter client can call its method.");

            Console.WriteLine(target.GetRequest());
        }
    }
}
