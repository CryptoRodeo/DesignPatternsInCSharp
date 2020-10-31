using design_patterns.factory_interface;
using design_patterns.product_interface;
using design_patterns.concrete_products;

namespace design_patterns.concrete_factories
{
    public class Samsung : IMobilePhone
    {
        public ISmartPhone GetSmartPhone()
        {
            return new SamsungGalaxy(); 
        }
        public INormalPhone GetNormalPhone()
        {
            return new SamsungGuru();
        }
    }
}