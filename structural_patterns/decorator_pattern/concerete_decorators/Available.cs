/// 
/// A ConcreteDecorator. This class will impart "responsibilities" onto the dishes (aka the wrapped objects)
/// Doing so this decorator alters the original result of the conceeate object in some way
/// (e.g. whether or not those dishes have enough ingredients left to order them)
/// 
using decorator_pattern.abstract_component;
using decorator_pattern.base_abstract_decorator;
using System;
using System.Collections.Generic;

namespace decorator_pattern.concerete_decorators
{
    public class Available : Decorator
    {
       public int NumAvailable {get; set;}  //How many can we make?
       protected List<string> customers = new List<string>();
       //RestaurantDish here is the wrapped object
       public Available(RestaurantDish dish, int numAvailable) : base(dish)
       {
           NumAvailable = numAvailable;
       }

       public void OrderItem(string name)
       {
           if (NumAvailable > 0)
           {
               customers.Add(name);
               NumAvailable--;
           }
           else
           {
               Console.WriteLine("\nNot enough ingredients for " + name + "'s order!");
           }
       }

    public override void Display()
    {
      base.Display();
      
      foreach(var customer in customers)
      {
          Console.WriteLine("Ordered by " + customer);
      }
      
    }

    }
}