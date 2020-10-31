using design_patterns.product_interface;

namespace design_patterns.concrete_products
{
    public class NokiaPixel : ISmartPhone
    {
        public string GetModelDetails()
       {
           return "Model: Nokia Pixel\nRAM: 3GB\nCamera: 8MP\n";
       } 
        
    }
}