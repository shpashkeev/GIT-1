using System;

namespace TypeOfTriangle
{
  // Class then contains method to return in main programm array with double values for sides of the triangle
  // And method fot checking the condition of existence of a triangle
  class InputerForTriangleSides
  {
    const string INPUT = "Enter values of sides:";
    const string CL_INPUT_ERROR = "Bad value, try again";
    const int SIDES = 3;

    // Method return array with permitted values
    public double[] Values()
    {
      double[] values = new double[SIDES];
      Console.WriteLine(INPUT);
      int i = 0;
      while (i < SIDES)
      {
        if (double.TryParse(Console.ReadLine(), out values[i]) && values[i] > 0)
        {
          i++;
          continue;
        }
        Console.WriteLine(CL_INPUT_ERROR);
      }
      return values;
    }
  }
}
