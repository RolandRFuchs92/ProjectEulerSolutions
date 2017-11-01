using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolutionsAssembly
{
	public class SumSquareDifference : ISolutionsContract
	{
		public string ProblemDescription => @"The sum of the squares of the first ten natural numbers is,\r\n" +
																					"12 + 22 + ... + 102 = 385\r\n" +
																					"The square of the sum of the first ten natural numbers is,\r\n" +
																					"(1 + 2 + ... + 10)2 = 552 = 3025\r\n" +
																					"Hence the difference between the sum of the squares of the first ten natural numbers and the square of the sum is 3025 − 385 = 2640.\r\n" +
																					"Find the difference between the sum of the squares of the first one hundred natural numbers and the square of the sum.";
		public string ProblemName => "Sum Square Difference";
		public int ProblemNumber => 6;

		public string Solution()
		{
			return ProblemSolution(1,100).ToString();
		}

		private int ProblemSolution(int startRange, int endRange)
		{
			var squareThenSum = 0;
			var sumThenSquare = 0;

			for (var inc = startRange; inc <= endRange; inc++)
			{
				sumThenSquare += inc;
				squareThenSum += (inc * inc);
			}
			sumThenSquare *= sumThenSquare;

			return sumThenSquare - squareThenSum;
		}
	}
}
