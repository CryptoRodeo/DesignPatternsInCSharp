using design_patterns.product_interface;

namespace design_patterns.concrete_products
{
    public class SamsungGalaxy : ISmartPhone
    {
        public string GetModelDetails()
       {
           return "Model: Samsung Galaxy\nRAM: 8GB\nCamera: 30MP\n";
       } 
        
    }
}