using System;
using System.Collections.Generic;
using System.Text;
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

            string row = "0, 1, 2, 3, 4, 5, 6.0, 7.0, 8.0, 9.0";

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
				{ 1, -22.00 }, { 2, -0.05 }, { 3, 0.00 }, { 4, -10.00 }, { 5, -11.00 }
			};
			
			int expected = 0;

			double result = lineMax.MaxIndex(count);

			Assert.AreEqual(expected, result);
		}

		[TestMethod]
		public void TestMethodBadLine()
		{
			DataProcessing lineMax = new DataProcessing();

			lineMax.ProcessingTape("..,.,.,.", 1);

			StringBuilder resultList = new StringBuilder("Line number with the maximum total of elements: \r\n");

			string maxAmount = String.Empty;

			resultList.Append("\r\n");

			resultList.Append(" Max Amount: " + maxAmount + "\r\n");

			resultList.Append("Line numbers with incorrect values: \r\n");

			resultList.Append(" " + 1);

			string expected = resultList.ToString();

			string result = lineMax.GetResult();

			Assert.AreEqual(expected, result);
		}
	}
}
