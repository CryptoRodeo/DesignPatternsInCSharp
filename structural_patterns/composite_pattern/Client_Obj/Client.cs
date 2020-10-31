using System;
using composite_pattern.ComponentInterface;

namespace composite_pattern.Client_Obj
{
    public class Client
    {
        public void ClientCode(Component leaf)
        {
            Console.WriteLine($"RESULT: {leaf.Operation()}\n");
        }

        public void ClientCode2(Component component1, Component component2)
        {
            if (component1.IsComposite())
            {
                component1.Add(component2);
            }

            Console.WriteLine($"Result: {component1.Operation()}");
        }
    }
}