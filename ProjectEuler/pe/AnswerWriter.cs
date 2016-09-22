using System;

namespace ProjectEuler
{
	internal static class AnswerWriter
	{
		public static void DisplayAnswer(string answer, int problemNumber)
		{
			Console.Write($"Problem {problemNumber}: {answer}".PadRight(25));
		}
	}
}