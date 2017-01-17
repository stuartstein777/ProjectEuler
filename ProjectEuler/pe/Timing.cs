using System;
using System.Diagnostics;

namespace ProjectEuler
{
	public class Timing
	{
		private readonly Stopwatch _stopWatch = new Stopwatch();

		public string TimeExecution(Action problem)
		{
			_stopWatch.Start();
			problem();
			_stopWatch.Stop();

			string timeTaken = $"Time taken {_stopWatch.Elapsed}";
			_stopWatch.Reset();

			return timeTaken;
		}
	}
}