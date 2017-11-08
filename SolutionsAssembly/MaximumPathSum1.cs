using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace SolutionsAssembly
{
	public class MaximumPathSum1 : ISolutionsContract
	{
		public string ProblemName => "Maximum Path Sum 1";
		public string ProblemDescription => $@"By starting at the top of the triangle below and moving to adjacent numbers on the row below, the maximum total from top to bottom is 23.

			3
			7 4
			2 4 6
			8 5 9 3

		That is, 3 + 7 + 4 + 9 = 23.

		Find the maximum total from top to bottom of the triangle below:

		{_pyramidHolder}

		NOTE: As there are only 16384 routes, it is possible to solve this problem by trying every route.However, Problem 67, is the same challenge with a triangle containing one-hundred rows; it cannot be solved by brute force, and requires a clever method! ;o)";
		public int ProblemNumber => 18;
		private string _pyramidHolder => 
		@"75
			95 64
			17 47 82
			18 35 87 10
			20 04 82 47 65
			19 01 23 75 03 34
			88 02 77 73 07 63 67
			99 65 04 28 06 16 70 92
			41 41 26 56 83 40 80 70 33
			41 48 72 33 47 32 37 16 94 29
			53 71 44 65 25 43 91 52 97 51 14
			70 11 33 28 77 73 17 78 39 68 17 57
			91 71 52 38 17 14 91 43 58 50 27 29 48
			63 66 04 68 89 53 67 30 73 16 69 87 40 31
			04 62 98 27 23 09 70 98 73 93 38 53 60 04 23";


		/*
		 * so link is awesome cause you can use it to effectively query arrays...
		 * i prefer this method as it looks neater and cleaner but the otherway looks more like SQL and i like SQL...
		 */
		 private int[][] _pyramidArray =>
					_pyramidHolder
							.Split('\n')
							.Select(
									t => t.Trim()
									.Split(' ')
									.Select(int.Parse)
									.ToArray()
							).ToArray();


		/*
		 this is a second way you could use link.... query an array as if it was a database object... freaking awesome!
			 */
		private string[][] _2pyramidArray => (from t in _pyramidHolder.Split('\n')
																					select (from i in t.Split(' ')
																									select i).ToArray()
																					).ToArray();


		public string Solution()
		{
			return SolutionProblem().ToString();
		}

		private int SolutionProblem()
		{
			int colPos = 0;
			int ans = _pyramidArray[0][0];
			for (int row = 0; row < _pyramidHolder.Length; row++)
			{
				int[][] miniTri = new int [3][];
				miniTri[0] = _pyramidArray[row + 1];
				miniTri[1] = _pyramidArray[row + 2];
				//miniTri[2] = _pyramidArray[row + 3];

				ans += GetBiggestPathValues(miniTri, colPos);
			}

			return ans;
		}

		private int GetBiggestPathValues(int [][]tri, int colPos)
		{
			int ans = 0;
			int []opt = new int[2];
			opt[0] = tri[0][colPos];
			opt[1] = tri[0][colPos - 1];
			opt[2] = tri[0][colPos + 1];

			ans += opt.Max();

			//opt

			return 0;
		}
	}
}
