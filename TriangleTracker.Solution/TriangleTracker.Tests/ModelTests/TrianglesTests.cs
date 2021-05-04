using Microsoft.VisualStudio.TestTools.UnitTesting;
using TriangleTracker;

namespace TriangleTracker.Tests
{
  [TestClass]
  public class TriangleTests
  {
    [TestMethod]
    public void TriangleChecker_ChecksTriangleType_NotATriangle()
    {
      Triangle newTriangle = new Triangle(2,2,8);
      Assert.AreEqual("Not a Triangle", newTriangle.CheckType());
    } 

    [TestMethod]
    public void TriangleChecker_ChecksTriangleType_Equelateral()
    {      
      Triangle newTriangle = new Triangle(2,2,2);
      Assert.AreEqual("The triangle is EQUILATERAL...", newTriangle.CheckType());
    } 

    [TestMethod]
    public void TriangleChecker_ChecksTriangleType_Iscoceles()
    {
      Triangle newTriangle = new Triangle(2,2,1);
      Assert.AreEqual("The triangle is ISOCELES...", newTriangle.CheckType());
    } 

    [TestMethod]
    public void TriangleChecker_ChecksTriangleType_Scalene()
    {
      Triangle newTriangle = new Triangle(2,3,1);
      Assert.AreEqual("The triangle is SCALENE...", newTriangle.CheckType());
    } 
  }
}
