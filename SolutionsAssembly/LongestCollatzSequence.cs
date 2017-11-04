using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolutionsAssembly
{
	public class LongestCollatzSequence : ISolutionsContract
	{
		public string ProblemDescription => @"The following iterative sequence is defined for the set of positive integers:

n → n/2 (n is even)
n → 3n + 1 (n is odd)

Using the rule above and starting with 13, we generate the following sequence:

13 → 40 → 20 → 10 → 5 → 16 → 8 → 4 → 2 → 1
It can be seen that this sequence (starting at 13 and finishing at 1) contains 10 terms. Although it has not been proved yet (Collatz Problem), it is thought that all starting numbers finish at 1.

Which starting number, under one million, produces the longest chain?

NOTE: Once the chain starts the terms are allowed to go above one million.";
		public string ProblemName => "Longest Collatz Sequence";
		public int ProblemNumber => 14;

		public string Solution()
		{
			return ProblemSolution(1000000).ToString();
		}

		private int ProblemSolution(int maxNumber)
		{
			var compareNum = 0;
			for (int i = 0; i < maxNumber; i++)
			{
				compareNum = countTerm(13) > compareNum ? countTerm : compareNum;
			}

			return 0 ;
		}


		private int countTerm(int startTerm)
		{
			var ans = startTerm;
			int count = 0;

			while (ans >= 1)
			{
				count++;
				Console.Write(ans + " > ");
				ans = ForkFormulas(ans);
			}

			return ++count;
		}

		private int ForkFormulas(int pos)
		{
			if (pos % 2 == 0)
				return EvenFormula(pos);
			else
				return OddFormula(pos);
		}

		private int EvenFormula(int num)
		{
			return num / 2;
		}

		private int OddFormula(int num)
		{
			return 3 * num + 1;
		}

	}
}
