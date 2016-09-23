using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProjectEuler;

namespace Tests
{
	[TestClass]
	public class UnitTest1
	{
		[TestMethod]
		public void TestPrimeNumberSieve()
		{
			const ulong upperBound = 30;
			var sieve = new PrimeNumberSieve();
			var primes = sieve.Sieve(upperBound);

			Assert.AreEqual(2ul, primes[0]);
			Assert.AreEqual(3ul, primes[1]);
			Assert.AreEqual(5ul, primes[2]);
			Assert.AreEqual(7ul, primes[3]);
			Assert.AreEqual(11ul, primes[4]);
			Assert.AreEqual(13ul, primes[5]);
			Assert.AreEqual(17ul, primes[6]);
			Assert.AreEqual(19ul, primes[7]);
			Assert.AreEqual(23ul, primes[8]);
			Assert.AreEqual(29ul, primes[9]);
			Assert.AreEqual(10, primes.Count);

		}

		[TestMethod]
		public void Test5IsPrime()
		{
			var sieve = new PrimeNumberSieve();
			Assert.IsTrue(sieve.IsPrime(5));
		}

		[TestMethod]	
		public void Test25IsNotPrime()
		{
			var sieve = new PrimeNumberSieve();
			Assert.IsFalse(sieve.IsPrime(25));
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
