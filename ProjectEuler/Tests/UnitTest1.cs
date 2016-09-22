using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProjectEuler;

namespace Tests
{
	[TestClass]
	public class UnitTest1
	{
		[TestMethod]
		public void TestRangeReturnsInts()
		{
			int upperBound = 100;
			IEnumerable<int> range = PrimeNumberSieve.GetRange(upperBound);

			int y = 1;
			foreach(int x in range)
			{
				Assert.AreEqual(x, y);
				y++;
			}
		}

		[TestMethod]
		public void TestRangeReturnsLongs()
		{
			long upperBound = 100;
			IEnumerable<long> range = PrimeNumberSieve.GetRange(upperBound);

			long y = 1;
			foreach (long x in range)
			{
				Assert.AreEqual(x, y);
				y++;
			}
		}

		[TestMethod]
		public void FindHighestFatorTestExampleGiven()
		{
			Assert.AreEqual(99, HelperMethods.FindHighestFactor(9009, 10, 99));
		}

		[TestMethod]
		public void FindHighestFatorTestAnswer()
		{
			Assert.AreEqual(993, HelperMethods.FindHighestFactor(906609, 100, 999));
		}
	}
}
