using FigureCalCulation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace ConsoleApp3.Tests
{
	[TestClass()]
	public class TriangleTests
	{
		[TestMethod()]
		public void CalculateSquareTest()
		{
			var expectedResult = 43.30127018922193;

			var triangle = new Triangle(10, 10, 10);
			var result = triangle.CalculateSquare();

			Assert.AreEqual(expectedResult, result);
		}

		[TestMethod()]
		public void ArgumentExceptionTest()
		{
			Assert.ThrowsException<ArgumentException>(() => new Triangle(10, -25, 30));
		}

		[TestMethod()]
		public void IsRightTriangleTest()
		{
			var expectedResult = true;

			var triangle = new Triangle(7, 24, 25);
			var result = triangle.IsRightTriangle();

			Assert.AreEqual(expectedResult, result);
		}
	}
}