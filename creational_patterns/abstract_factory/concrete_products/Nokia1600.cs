using design_patterns.product_interface;

namespace design_patterns.concrete_products
{
    public class Nokia1600 : INormalPhone
    {
       public string GetModelDetails()
       {
           return "Model: Nokia 1600\nRAM: N/A\nCamera: 1MP\n";
       } 
    }
}