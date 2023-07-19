using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace get_set
{
  public class Train
  {
    public Train(int speed)
    {
      MaximumSpeed = speed;
    }
    int _speed;

    public int MaximumSpeed
    {
      get { return _speed; }
      set { _speed = value; }
    }
  }
}