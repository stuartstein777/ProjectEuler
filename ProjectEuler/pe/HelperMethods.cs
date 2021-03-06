using System;
using System.Collections.Generic;
using System.Linq;

namespace ProjectEuler
{
	public static class HelperMethods
	{
		public static int GetFactorial(int n)
		{
			var f = 1;
			for (var x = 1; x <= n; x++)
				f *= x;
			return f;
		}
		public static int GetNextFibonnaci(int x, int y)
		{
			return x + y;
		}
		public static int FindHighestFactor(uint x, int lowerBound, int upperBound)
		{
			var factor = upperBound;
			while(factor > lowerBound)
			{
				if ((x % factor == 0) && (x / factor <= upperBound))
					return factor;
				factor--;
			}
			return 0;
		}
		public static string Reverse(string toReverse)
		{
			var reversed = string.Empty;
			for(int x = toReverse.Length - 1; x >= 0; x--)
				reversed += toReverse[x];
			return reversed;
		}
		public static ulong Sum(this IEnumerable<ulong> source)
		{
			return source.Aggregate((x, y) => x + y);
		}

		public static int FindNumberOfFactors(long toFactor)
		{
			int numFactors = 0;

			for (long i = 1; i < Math.Sqrt(toFactor); i++)
			{
				if (toFactor % i == 0)
					numFactors++;
			}
			return numFactors * 2;
		}
	}
}