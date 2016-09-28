using System;
using System.Collections.Generic;
using System.Linq;

namespace ProjectEuler
{
	public class PrimeNumberSieve
	{
		public IList<ulong> Sieve(ulong upperBound)
		{
			var primes = GetRangeInclusive(upperBound);
			for(var x = 0; x <= Math.Sqrt(primes.Count); x++)
			{
				if(primes[x] != 0)
				{
					var i = primes[x];
					var iSquared = i*i;
					var c = (ulong)0;
					ulong indexToZero;
					while ((indexToZero = iSquared + c * i) < (ulong)primes.Count+2)
					{
						primes[(int)indexToZero - 2] = 0;
						c++;
					}
				}
			}
			return primes.Select(x => x).Where(x => x != 0).ToList();
		}
		public bool IsPrime(ulong x)
		{
			for(ulong c = 2; c <= Math.Sqrt(x); c++)
				if(x % c == 0) return false;
			return true;
		}
		private IList<ulong> GetRangeInclusive(ulong upperBound)
		{
			var range = new List<ulong>();
			for (ulong x = 2; x <= upperBound; x++)
				range.Add(x);
			return range;
		}
	}
}