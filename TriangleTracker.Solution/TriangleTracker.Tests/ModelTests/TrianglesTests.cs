using Microsoft.VisualStudio.TestTools.UnitTesting;
using TriangleTracker;

namespace TriangleTracker.Tests
{
  [TestClass]
  public class TriangleTests
  {
    [TestMethod]
    public void TriangleChecker_ChecksTriangleType_TriangleType()
    {
      Triangle NewTriangle = new Triangle(2,2,8);
      Assert.AreEqual(false, Triangle.CheckType(2,2,8));
    } 
  }
}
