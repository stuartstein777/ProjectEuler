using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectEuler
{
	class Program
	{
		static void Main()
		{
			Timing timing = new Timing();

			Console.WriteLine("\t : " + timing.TimeExecution(Problem1));
			Console.WriteLine("\t : " + timing.TimeExecution(Problem2));
			Console.WriteLine("\t : " + timing.TimeExecution(Problem4));
			Console.WriteLine("\t : " + timing.TimeExecution(Problem5));
			Console.WriteLine("\t : " + timing.TimeExecution(Problem6));
			Console.WriteLine("\t : " + timing.TimeExecution(Problem14));
			Console.WriteLine("\t : " + timing.TimeExecution(Problem14BruteForce));
			Console.WriteLine("\t : " + timing.TimeExecution(Problem34));


			Console.ReadKey();
		}

		static void Problem1()
		{
			var answer = 0;

			for (var x = 1; x < 1000; x++)
			{
				if (x % 3 == 0 || x % 5 == 0)
					answer += x;
			}

			AnswerWriter.DisplayAnswer(answer.ToString(), 1);
		}

		static void Problem2()
		{
			var answer = 2;
			var x = 1;
			var y = 2;
			var f = 0;

			while (f <= 4000000)
			{
				f = HelperMethods.GetNextFibonnaci(x, y);

				if (f % 2 == 0)
					answer += f;

				x = y;
				y = f;
			}

			AnswerWriter.DisplayAnswer(answer.ToString(), 2);
		}

		//
		// A palindromic number reads the same both ways. The largest palindrome made from the product of two 2-digit numbers is 9009 = 91 × 99.
		//
		// Find the largest palindrome made from the product of two 3-digit numbers.
		static void Problem4()
		{
			uint answer = 0;
			var a = 999;

			while (a > 100)
			{
				string b = a + HelperMethods.Reverse(a.ToString());
				var c = Convert.ToUInt32(b);

				if (HelperMethods.FindHighestFactor(c, 100, 999) > 99)
				{
					answer = c;
					break;
				}
				a--;
			}

			AnswerWriter.DisplayAnswer(answer.ToString(), 4);
		}

		static void Problem5()
		{
			bool answerFound = false;
			ulong x = 0;

			while (!answerFound)
			{
				x += 20;
				answerFound = true;
				for (ulong c = 1; c <= 20; c++)
				{
					if (x % c != 0)
					{
						answerFound = false;
						break;
					}
				}
			}

			AnswerWriter.DisplayAnswer(x.ToString(), 5);
		}

		static void Problem6()
		{
			const int upperBound = 100;
			var sumOfSquares = 0;
			var squareOfSums = 0;

			for (var i = 1; i <= upperBound; i++)
			{
				sumOfSquares += i * i;
				squareOfSums += i;
			}

			squareOfSums *= squareOfSums;
			var answer = squareOfSums - sumOfSquares;

			AnswerWriter.DisplayAnswer(answer.ToString(), 6);

		}

		static void Problem14BruteForce()
		{
			const ulong upperBound = 1000000;
			uint answer = 0;
			uint longestChain = 0;

			for (uint x = 2; x <= upperBound; x++)
			{
				ulong y = x;
				uint chainLength = 0;

				do
				{
					++chainLength;

					if ((y & 1) == 1)
						y += (y << 1) + 1;
					else
						y /= 2;

				} while (y != 1);

				if (chainLength > longestChain)
				{
					longestChain = chainLength;
					answer = x;
				}
			}

			AnswerWriter.DisplayAnswer(answer + " -- BF ", 14);
		}

		static void Problem14()
		{
			var knownChainLengths = new Dictionary<ulong, int>();
			knownChainLengths.Add(1, 1);

			for (ulong x = 1000000; x > 1; x--)
			{
				var currentChain = new List<ulong>();
				var y = x;
				var chainLengthFromCurrentPoint = 0;

				if (!knownChainLengths.ContainsKey(x))
				{
					do
					{
						currentChain.Insert(0, y);

						if ((y & 1) == 1)
							y += (y << 1) + 1;
						else
							y /= 2;

						if (knownChainLengths.ContainsKey(y))
						{
							knownChainLengths.TryGetValue(y, out chainLengthFromCurrentPoint);
							UpdateDictionary(knownChainLengths, currentChain, chainLengthFromCurrentPoint);
							break;
						}

					} while (y != 1);
				}

				UpdateDictionary(knownChainLengths, currentChain, chainLengthFromCurrentPoint);
			}

			AnswerWriter.DisplayAnswer(knownChainLengths.Aggregate((l, r) => l.Value > r.Value ? l : r).Key.ToString(), 14);
		}

		static void UpdateDictionary(IDictionary<ulong, int> knownChainLengths, IList<ulong> currentChain, int chainLengthToZero)
		{
			for (int index = 0; index < currentChain.Count; index++)
			{
				var i = currentChain[index];
				if (!knownChainLengths.ContainsKey(i))
				{
					var length = currentChain.IndexOf(i) + 1 + chainLengthToZero;
					knownChainLengths.Add(i, length);
				}
			}
		}

		static void Problem34()
		{
			var answer = 0;

			for (var currentNumber = 10; currentNumber < 42500; currentNumber++)
			{
				var x = currentNumber;
				var total = 0;

				while (x > 0)
				{
					var y = x % 10;
					total += HelperMethods.GetFactorial(y);
					x /= 10;
				}

				if (total == currentNumber)
					answer += total;
			}

			AnswerWriter.DisplayAnswer(answer.ToString(), 34);
		}
	}
}
