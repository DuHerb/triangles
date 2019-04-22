using System;

namespace TriangleTracker
{

  class Program
  {

    static void Main()
    {
      Console.WriteLine("Input Side One: ");
      string stringSideOne = Console.ReadLine();
      int sideOne = int.Parse(stringSideOne);

      Console.WriteLine("Input Side Two: ");
      string stringSideTwo = Console.ReadLine();
      int sideTwo = int.Parse(stringSideTwo);

      Console.WriteLine("Input Side Three: ");
      string stringSideThree = Console.ReadLine();
      int sideThree = int.Parse(stringSideThree);

      Triangle userTriangle = new Triangle(sideOne, sideTwo, sideThree);

      if(userTriangle.IsTriangle())
      {
        userTriangle.TriangleType();
      }
    }
  }
}
