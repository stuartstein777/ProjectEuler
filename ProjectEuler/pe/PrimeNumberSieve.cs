using System.Collections.Generic;
using System.Linq;

namespace ProjectEuler
{
	public static class PrimeNumberSieve
	{
		//public static IList<ulong> Sieve(ulong upperBound) 
		//{
		//	IList<ulong> primes = GetRange(upperBound);

		//	for(ulong x = 2; x < Math.Sqrt(upperBound); x++)
		//	{
		//		ulong y = x;
		//		while (y < upperBound)
		//		{
		//			primes.Remove(y);
		//			y += y;
					
		//		}
		//	}

		//	return primes;
		//}

		public static bool IsPrime(ulong x)
		{
			ulong y = 2;

			while(x % y != 0)
			{
				return true;
			}

			return false;
		}

		public static IEnumerable<T> GetRange<T>(T upperBound)
		{
			IList<T> range = new List<T>();

			T x = One<T>();

			while(AreEqual(upperBound, x))
			{
				range.Add(x);
				x = Add(x, One<T>());
			}

			return range.AsEnumerable();
		}

		private static T Zero<T>()
		{
			return (dynamic)0;
		}

		private static T One<T>()
		{
			return (dynamic)1;
		}

		private static T Add<T>(T x, T y)
		{
			dynamic a = x;
			dynamic b = y;

			return a + b;
		}

		private static bool AreEqual<T>(T x, T y)
		{
			dynamic a = x;
			dynamic b = y;

			return a == b;
		}
	}
}