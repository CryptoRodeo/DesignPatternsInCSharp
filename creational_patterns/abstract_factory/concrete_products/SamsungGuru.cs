using design_patterns.product_interface;

namespace design_patterns.concrete_products
{
    public class SamsungGuru : INormalPhone
    {
        public string GetModelDetails()
       {
           return "Model: SamsungGuru\nRAM: N/A\nCamera: 2MP\n";
       }     
    }
}