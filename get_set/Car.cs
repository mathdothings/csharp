using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace get_set
{
  public class Car : ICar
  {
    public Car(int maximumVelocity)
    {
      MaximumVelocity = maximumVelocity;
    }
    int _maximumVelocity;

    public int MaximumVelocity
    {
      get { return _maximumVelocity; }
      set { _maximumVelocity = value; }
    }
  }
}