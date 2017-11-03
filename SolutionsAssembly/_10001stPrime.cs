using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SolutionsAssembly.Dry;

namespace SolutionsAssembly
{
	public class _10001stPrime : ISolutionsContract
	{
		public string ProblemDescription => "By listing the first six prime numbers: 2, 3, 5, 7, 11, and 13, we can see that the 6th prime is 13.\r\n" +
																					"What is the 10 001st prime number?";
		public string ProblemName => "10001st Prime";
		public int ProblemNumber => 7;

		public string Solution()
		{
			return ProblemSolution(10001).ToString();
		}

		private int ProblemSolution(int primeInc)
		{
			var ans = 0;
			for (int inc = 2; ; inc++)
			{
				if (Dry.DryCode.IsPrime(inc))
				{
					ans++;
					if (ans == primeInc)
						return inc;
				}
			}
		}
	}
}
