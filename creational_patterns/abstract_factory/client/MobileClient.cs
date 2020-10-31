using design_patterns.product_interface;
using design_patterns.factory_interface;
using design_patterns.concrete_factories;
using design_patterns.concrete_products;
using System;

namespace design_patterns.client
{
    public class MobileClient
    {
        public ISmartPhone smartPhone;
        public INormalPhone normalPhone;
        public MobileClient(IMobilePhone factory)
        {
            this.smartPhone = factory.GetSmartPhone();
            this.normalPhone = factory.GetNormalPhone();
        }
       public string GetSmartPhoneModelDetails()
        {
            return this.smartPhone.GetModelDetails();
        }
        public string GetNormalPhoneModelDetails()
        {
            return this.normalPhone.GetModelDetails();
        }
    }
}