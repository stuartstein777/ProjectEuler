namespace ProjectEuler
{
	public static class HelperMethods
	{
		public static int GetFactorial(int n)
		{
			var f = 1;

			for (var x = 1; x <= n; x++)
			{
				f *= x;
			}

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
			{
				reversed += toReverse[x];
			}

			return reversed;
		}
	}
}