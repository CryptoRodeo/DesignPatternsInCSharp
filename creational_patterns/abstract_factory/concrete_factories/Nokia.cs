using design_patterns.factory_interface;
using design_patterns.product_interface;
using design_patterns.concrete_products;

namespace design_patterns.concrete_factories
{
    public class Nokia : IMobilePhone
    {
       public ISmartPhone GetSmartPhone()
       {
           return new NokiaPixel();
       } 
       public INormalPhone GetNormalPhone()
       {
           return new Nokia1600();
       }
    }
}