using System;
using composite_pattern.ComponentInterface;

namespace composite_pattern.Leafs
{
    public class Leaf : Component
    {
        public override string Operation()
        {
            return "leaf";
        }

        public override bool IsComposite()
        {
            return false;
        }
    }
}