using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolutionsAssembly
{
	public class SmallestMultiple : ISolutionsContract
	{
		public string ProblemDescription => "2520 is the smallest number that can be divided by each of the numbers from 1 to 10 without any remainder.\r\n" +
																				"What is the smallest positive number that is evenly divisible by all of the numbers from 1 to 20?";
		public string ProblemName => "Smallest Multiple";
		public int ProblemNumber => 5;

		public int Solution()
		{
			return ProblemSolution(1, 20);
		}

		private int ProblemSolution(int startRange, int endRange)
		{
			var inc = 0;
			for(inc = 1; ;inc++)
				for (var divBy = startRange; divBy <= endRange; divBy++)
				{
					if (inc % divBy == 0 && divBy == endRange)
						return inc;
					else if (inc % divBy == 0)
						continue;
					else
						break;
				}
		}
	}
}
