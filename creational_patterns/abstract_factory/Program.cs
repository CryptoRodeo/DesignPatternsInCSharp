using System;
using design_patterns.factory_interface;
using design_patterns.product_interface;
using design_patterns.concrete_factories;
using design_patterns.concrete_products;
using design_patterns.client;

namespace design_patterns
{
    class Program
    {
        static void Main(string[] args)
        {

            IMobilePhone nokiaMobilePhone = new Nokia();  
            MobileClient nokiaClient = new MobileClient(nokiaMobilePhone);  
  
            Console.WriteLine("********* NOKIA **********");  
            Console.WriteLine(nokiaClient.GetSmartPhoneModelDetails());  
            Console.WriteLine(nokiaClient.GetNormalPhoneModelDetails());  
              
            IMobilePhone samsungMobilePhone = new Samsung();  
            MobileClient samsungClient = new MobileClient(samsungMobilePhone);  
  
            Console.WriteLine("******* SAMSUNG **********");  
            Console.WriteLine(samsungClient.GetSmartPhoneModelDetails());  
            Console.WriteLine(samsungClient.GetNormalPhoneModelDetails());  
  
            Console.ReadKey();
        }
    }
}
