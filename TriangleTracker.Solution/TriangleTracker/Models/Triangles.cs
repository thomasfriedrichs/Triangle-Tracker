namespace TriangleTracker 
{
  public class Triangle
  {
    // use auto-implemented properties!
    private int _side1;
    private int _side2;
    private int _side3;

    // public void SetNumber1(int Number1)
    // {
    //   _side1 = Number1;
    // }

    // public void SetNumber2(int Number2)
    // {
    //   _side2 = Number2;
    // }

    // public void SetNumber3(int Number3)
    // {
    //   _side3 = Number3;
    // }

    public Triangle(int side1, int side2, int side3)
    {
      _side1 = side1;
      _side2 = side2;
      _side3 = side3;
    }

    public string CheckType()
    {
      if ((_side1 + _side2) < _side3 || (_side1 + _side3) < _side2 || (_side2 + _side3) < _side1)
      {
        return "Not a Triangle";
      } else if (_side1 == _side2 && _side2 == _side3 && _side1 == _side3) 
      {
        return "The triangle is EQUILATERAL...";
      } else if (_side1 == _side2 || _side1 == _side3) 
      {
        return "The triangle is ISOCELES...";
      } else 
      {
        return "The triangle is SCALENE...";
      }
    }
  }
}
