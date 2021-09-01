using Microsoft.VisualStudio.TestTools.UnitTesting;
using TriangleTracker;

namespace TriangleTracker.Tests
{
  [TestClass]
  public class TriangleTests
  {
    [TestMethod]
    public void IsValidTriangle_CheckIfValidTriangle_True(){
      Triangle testTriangle = new Triangle();
      Assert.AreEqual(true, testTriangle.IsValidTriangle(500,2000,2));
    }
    // [TestMethod]
    // public void IsValidTriangle_CheckIfNotValidTriangle_False(){
    //   Triangle testTriangle = new Triangle();
    //   Assert.AreEqual(false, testTriangle.IsValidTriangle(2,2,8));
    // }

    [TestMethod]
    public void GetTriangleType_GetTypeOfTheTriangle_EquilateralAndIsosceles(){
      Triangle triangleType = new Triangle();
      Assert.AreEqual("equilateral and isosceles", triangleType.GetTriangleType(3,3,3));
    }

    [TestMethod]
    public void GetTriangleType_GetTypeOfTheTriangle_Isosceles(){
      Triangle triangleType = new Triangle();
      Assert.AreEqual("isosceles", triangleType.GetTriangleType(3,2,3));
    }

    [TestMethod]
    public void GetTriangleType_GetTypeOfTheTriangle_Scalene(){
      Triangle triangleType = new Triangle();
      Assert.AreEqual("scalene", triangleType.GetTriangleType(6,5,3));
    }
  }



}