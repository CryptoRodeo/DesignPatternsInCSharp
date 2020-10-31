using System;
using design_patterns.product_interface;

namespace design_patterns.factory_interface
{
  //abstract factory interface
  public interface IMobilePhone
  {
    //The methods that are going to be implemented
    // by classes inheriting this interface.
    public ISmartPhone GetSmartPhone();
    public INormalPhone GetNormalPhone();
  }
}