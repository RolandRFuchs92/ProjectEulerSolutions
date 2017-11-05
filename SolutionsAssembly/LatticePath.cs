using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolutionsAssembly
{
	public class LatticePath :ISolutionsContract
	{

		public string ProblemName => "Lattice Path";
		public string ProblemDescription => 
@"Starting in the top left corner of a 2×2 grid, and only being able to move to the right and down, there are exactly 6 routes to the bottom right corner.

How many such routes are there through a 20×20 grid?";

		public int ProblemNumber => 15;

		public string Solution()
		{
			return ProblemSolution().ToString();
		}

		private long ProblemSolution()
		{
			return GetPathsCount(21);
		}

		private long GetPathsCount(int gridSize)
		{
			long [][] latticGrid = InitLatticGrid(gridSize);


			for (int row = 1; row < gridSize; row++)
			{
				for (int col = 1; col < gridSize; col++)
				{
					latticGrid[row][col] = latticGrid[row][col] == 0 ? latticGrid[row - 1][col] + latticGrid[row][col - 1] : latticGrid[row][col]; //horizontal setup
					latticGrid[col][row] = latticGrid[col][row] == 0 ? latticGrid[row - 1][col] + latticGrid[row][col - 1] : latticGrid[col][row]; //verticle setup
				}
			}
			//plotToTextFile(latticGrid);
			return latticGrid[gridSize-1][gridSize-1];
		}

		/// <summary>
		/// Innitialise the Lattice Grid... sets the rows and columns to value 1 and everything else to 0;
		/// 1 1 1 1
		/// 1 0 0 0 
		/// 1 0 0 0
		/// 1 0 0 0
		/// </summary>
		/// <param name="gridSize"></param>
		/// <returns></returns>
		private long[][]InitLatticGrid(int gridSize)
		{
			long [][] initLattic = new long[gridSize][];

			for (int row = 0; row < gridSize; row++)
			{
				long[] rowArray = new long[gridSize];
				for (int col = 0; col < gridSize; col++)
				{
					rowArray[col] = row == 0 || col == 0 ? 1 : 0;
				}
				initLattic[row] = rowArray;
			}


			return initLattic;
		}

		private void plotToTextFile(long [][] grid)
		{
			string[] lines = new string[grid.Length];

			for (int row = 0; row < grid.Length; row++)
				for (int col = 0; col < grid.Length; col++)
					lines[row] += $"{grid[row][col]},";

			System.IO.File.WriteAllLines(@"C:\Users\Len159\Desktop\upload\Roland\test.txt", lines);
		}
	}
}
