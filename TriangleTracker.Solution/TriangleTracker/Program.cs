using System;


namespace TriangleTracker
{
  public class Program
  {
    public static void Main()
    {
      Console.WriteLine("Enter a side dimension");
      int first = int.Parse(Console.ReadLine());
      Console.WriteLine("Enter a second side dimension");
      int second = int.Parse(Console.ReadLine());
      Console.WriteLine("Enter a third side dimension");
      int third = int.Parse(Console.ReadLine());
    Triangle userTriangle = new Triangle(first, second, third);
    Console.WriteLine(userTriangle.CheckType());
    Main();
    }
  } 
}

