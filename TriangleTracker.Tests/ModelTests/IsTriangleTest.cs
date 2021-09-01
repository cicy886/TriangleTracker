using Microsoft.VisualStudio.TestTools.UnitTesting;
using TriangleTracker;

namespace TriangleTracker.Tests
{
  [TestClass]
  public class IsTriangleTests
  {
    [TestMethod]
    public void IsValidTriangle_CheckIfValidTriangle_True(){
      IsTriangle testTriangle = new IsTriangle();
      Assert.AreEqual(true, testTriangle.IsValidTriangle(500,2000,2));
    }
  }
}