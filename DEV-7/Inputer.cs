using System;

namespace TypeOfTriangle
{
  // Class then contains method to return in main programm array with double values for sides of the triangle
  // And method fot checking the condition of existence of a triangle
  class Inputer
  {
    const string INPUT = "Enter values of sides:";
    const string DONOTEXIST = "Triangle with such sides does not exist. Please, try again";
    const string CL_INPUT_ERROR = "Bad value, try again";

    // Method return array with permitted values
    public double[] Values()
    {
      double[] values = new double[3];
      bool validate = false;
      do
      {
        Console.WriteLine(INPUT);
        int i = 0;
        while (i < 3)
        {
          if (double.TryParse(Console.ReadLine(), out values[i]) && values[i] > 0)
          {
            i++;
            continue;
          }
          Console.WriteLine(CL_INPUT_ERROR);
        }
        validate = ValidateTriangleExistence(values[0], values[1], values[2]);
        if (validate == false)
        {
          Console.WriteLine(DONOTEXIST);
        }
      }
      while (validate == false);
      return values;
    }

    public bool ValidateTriangleExistence(double sideA, double sideB, double sideC)
    {
      // Condition for the existence of a triangle
      if (sideA + sideB >= sideC && sideB + sideC >= sideA && sideA + sideC >= sideB)
      {
        return true;
      }
      return false;
    }
  }
}
