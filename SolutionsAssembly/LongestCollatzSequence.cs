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

		private long ProblemSolution(int maxNumber)
		{
			long compareNum = 0;
			int startNum = 0;
			for (int i = maxNumber; i > 0; i--)
			{
				var countTerm = CountTerm(i);
				startNum = countTerm > compareNum ? i : startNum;
				compareNum = countTerm > compareNum ? countTerm : compareNum;
			}

			return startNum;
		}


		private int CountTerm(int startTerm)
		{
			long ans = startTerm;
			int count = 0;

			while (ans != 1)
			{
				count++;
				ans = ForkFormulas(ans);
			}

			return ++count;
		}

		private long ForkFormulas(long pos)
		{
			if (pos % 2 == 0)
				return EvenFormula(pos);
			else
				return OddFormula(pos);
		}

		private long EvenFormula(long num)
		{
			return num / 2;
		}

		/// <summary>
		/// Shortcut to Colats Formula...
		/// </summary>
		/// <param name="num"></param>
		/// <returns></returns>
		private long OddFormula(long num)
		{
			return (3 * num + 1)/2;// Div 2 is magical...
		}

	}
}
