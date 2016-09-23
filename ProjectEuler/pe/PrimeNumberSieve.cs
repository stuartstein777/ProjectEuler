using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace ProjectEuler
{
	public class PrimeNumberSieve
	{
		public IList<ulong> Sieve(ulong upperBound)
		{
			var primes = GetRangeInclusive(upperBound);

			for(var x = 0; x < primes.Count; x++)
			{
				var y = primes[x];

				if(y == 0) continue;

				var locationStep = (ulong)x;

				if (IsPrime(y))
				{
					do
					{
						locationStep += y;
						if(locationStep < (ulong)primes.Count)
							primes[(int)locationStep] = 0;

					} while (locationStep < (ulong)primes.Count);
				}
			}
			return primes.Select(x => x).Where(x => x != 0).ToList();
		}

		public bool IsPrime(ulong x)
		{
			for(ulong c = 2; c <= Math.Sqrt(x); c++)
			{
				if(x % c == 0)
					return false;
			}

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