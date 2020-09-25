using System;
using System.Collections.Generic;
using LineMax;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace LineMaxTests
{
	[TestClass]
	public class UnitTest1
	{
		[TestMethod]
		public void TestMethodTape()
		{
            DataProcessing lineMax = new DataProcessing();

            string row = "0, 1, 2, 3, 4, 5, '', 6.0, 7.0, 8.0, 9.0";

			double expected = 45;

			double result = lineMax.ProcessingTape(row, 1);

			Assert.AreEqual(expected, result);
		}

		[TestMethod]
		public void TestMethodMaxIndex()
		{
            DataProcessing lineMax = new DataProcessing();

            Dictionary<int, double> count = new Dictionary<int, double>(5)
			{
				{ 1, -22.00 }, { 2, 0.05 }, { 3, 0.00 }, { 4, 120.00 }, { 5, 11.00 }
			};
			
			int expected = 4;

			double result = lineMax.MaxIndex(count);

			Assert.AreEqual(expected, result);
		}
	}
}
