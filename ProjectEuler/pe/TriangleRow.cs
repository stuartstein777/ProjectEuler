using System.Collections.Generic;

namespace ProjectEuler
{
	class TriangleRow
	{
		private readonly List<int> _values = new List<int>();
		public TriangleRow(params int[] vals)
		{
			foreach (var i in vals)
				_values.Add(i);
		}
		public List<int> Values => _values;
	}
}