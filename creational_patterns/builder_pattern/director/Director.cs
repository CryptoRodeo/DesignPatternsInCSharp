
using builder_pattern.products;
using builder_pattern.builder_interface;
using builder_pattern.concrete_builder;

namespace builder_pattern.director
{
    public class Director
    {
        private IBuilder _builder;

        //property
        public IBuilder Builder
        {
            set { _builder = value; }
        }

        public void buildMinimalViableProduct()
        {
            this._builder.BuildPartA();
        }

        public void buildFullFeaturedProduct()
        {
            this._builder.BuildPartA();
            this._builder.BuildPartB();
            this._builder.BuildPartC();
        }
    }
}