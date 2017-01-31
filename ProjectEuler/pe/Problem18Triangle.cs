using System.Collections.Generic;

namespace ProjectEuler
{
	class Problem18Triangle
	{
		private readonly List<TriangleRow> _rows = new List<TriangleRow>();

		public Problem18Triangle()
		{
			AddRow(new TriangleRow(75));
			AddRow(new TriangleRow(95, 64));
			AddRow(new TriangleRow(17, 47, 82));
			AddRow(new TriangleRow(18, 35, 87, 10));
			AddRow(new TriangleRow(20, 04, 82, 47, 65));
			AddRow(new TriangleRow(19, 01, 23, 75, 03, 34));
			AddRow(new TriangleRow(88, 02, 77, 73, 07, 63, 67));
			AddRow(new TriangleRow(99, 65, 04, 28, 06, 16, 70, 92));
			AddRow(new TriangleRow(41, 41, 26, 56, 83, 40, 80, 70, 33));
			AddRow(new TriangleRow(41, 48, 72, 33, 47, 32, 37, 16, 94, 29));
			AddRow(new TriangleRow(53, 71, 44, 65, 25, 43, 91, 52, 97, 51, 14));
			AddRow(new TriangleRow(70, 11, 33, 28, 77, 73, 17, 78, 39, 68, 17, 57));
			AddRow(new TriangleRow(91, 71, 52, 38, 17, 14, 91, 43, 58, 50, 27, 29, 48));
			AddRow(new TriangleRow(63, 66, 04, 68, 89, 53, 67, 30, 73, 16, 69, 87, 40, 31));
			AddRow(new TriangleRow(04, 62, 98, 27, 23, 09, 70, 98, 73, 93, 38, 53, 60, 04, 23));
		}
		public bool IsLastRow(int r)
		{
			return r > _rows.Count;
		}
		public void AddValueToCol(int val, int row, int col)
		{
			_rows[row].Values[col] += val;
		}
		public int RowCount => _rows.Count;
		public int ItemsInRow(int row)
		{
			return _rows[row].Values.Count;
		}
		public void AddRow(TriangleRow newRow)
		{
			_rows.Add(newRow);
		}
		public int RowColvalue(int row, int col)
		{
			return _rows[row].Values[col];
		}
		public void NextNodeLeft(int row, int col, out int nextRow, out int nextCol)
		{
			nextRow = ++row;
			nextCol = col;
		}
		public void NextRowRight(int row, int col, out int nextRow, out int nextCol)
		{
			nextRow = ++row;
			nextCol = col + 1;
		}
	}
}
