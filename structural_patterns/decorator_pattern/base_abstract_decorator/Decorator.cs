
using decorator_pattern.abstract_component;
namespace decorator_pattern.base_abstract_decorator
{
     // The base Decorator class follows the same interface as the other
    // components. The primary purpose of this class is to define the wrapping
    // interface for all concrete decorators. The default implementation of the
    // wrapping code might include a field for storing a wrapped component and
    // the means to initialize it.

    //In this class there is no default implementation
    public abstract class Decorator : RestaurantDish
    {
       protected RestaurantDish _dish; 

       public Decorator(RestaurantDish dish)
       {
           _dish = dish;
       }

        //Here all the work is delegated to the wrapped component
        public override void Display()
        {
            _dish.Display();
        }

    }
}