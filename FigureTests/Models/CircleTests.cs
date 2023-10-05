using FigureCalCulation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Figure.Tests
{
	[TestClass()]
	public class CircleTests
	{
		[TestMethod()]
		public void ArgumentExceptionTest()
		{
			Assert.ThrowsException<ArgumentException>(() => new Circle(-10));
		}

		[TestMethod()]
		public void CalculateSquareTest()
		{
			var expectedResult = 314.1592653589793;

			var circle = new Circle(10);
			var result = circle.CalculateSquare();

			Assert.AreEqual(expectedResult, result);
		}
	}
}