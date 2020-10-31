using decorator_pattern.abstract_component;
using System;
namespace decorator_pattern.concerete_component
{
    // Concrete components provide default implementations of the operations.
    // There could be several variations of this class
    public class Pasta : RestaurantDish
    {
       private string _pastaType;
       private string _sauce;

       public Pasta(string pastaType, string sauce)
       {
            _pastaType = pastaType;
            _sauce = sauce;
       }

    public override void Display()
    {
        Console.WriteLine("\nClassic Pasta:");
        Console.WriteLine(" Pasta: {0}", _pastaType);
        Console.WriteLine(" Sauce: {0}", _sauce);
    }

    }
}