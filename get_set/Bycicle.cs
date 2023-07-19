using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace get_set
{

  public class Bycicle : IBycicle
  {
    public Bycicle(int pedalStrokes)
    {
      MaximumPedalStrokes = pedalStrokes;
    }
    int _pedalStrokes;

    public int MaximumPedalStrokes
    {
      get { return _pedalStrokes; }
      set { MaximumPedalStrokes = value; }
    }
  }
}