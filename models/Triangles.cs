using System;
using System.Collections.Generic;

namespace TriangleTracker
{

  class Triangle
  {

    private int SideOne;
    private int SideTwo;
    private int SideThree;

    public Triangle(int sideOne, int sideTwo, int sideThree)
    {
      SideOne = sideOne;
      SideTwo = sideTwo;
      SideThree = sideThree;
    }

    public bool IsTriangle()
    {
      int[] sides = { SideOne, SideTwo, SideThree };
      bool isTriangle = true;
      for(int i = 0; i < sides.Length; i++)
      {
        if(sides[i] > SideOne + SideTwo + SideThree - sides[i])
        {
          Console.WriteLine("Not a Triangle");
          isTriangle = false;
        }
      }
      return isTriangle;
    }

    public void TriangleType()
    {
      if(SideOne == SideTwo && SideTwo == SideThree)
      {
        Console.WriteLine("Equilateral");
      }
      else if (SideOne == SideTwo || SideOne == SideThree || SideTwo == SideThree)
      {
        Console.WriteLine("Isosceles");
      }
      else
      {
        Console.WriteLine("Scalene");
      }
    }
  }
}
