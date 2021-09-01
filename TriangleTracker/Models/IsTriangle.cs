using System;
namespace TriangleTracker
{
  public class Triangle
  {
    // properties, constructors, methods, etc. go here
    public bool IsValidTriangle(int a, int b, int c){
      double legs = a + b; 
    if (legs >= c){
      return true;
    } else {
      return false;
    }
    }

    //check triangle type
    public string GetTriangleType(int a, int b, int c){
      string result = "";
      if (a == b &&  b == c){
        result = ("equilateral and isosceles");
      }  else if (a == b || b == c || c == a){
        result = ("isosceles");
      } else if (a != b && b != c && c !=a){
        result = ("scalene");
      }
      return result;
    }
    }
}
