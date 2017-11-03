using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SolutionsAssembly.Dry;

namespace SolutionsAssembly
{
	public class SummationOfPrimes : ISolutionsContract
	{
		public string ProblemName => "Summation of primes";
		public string ProblemDescription =>
@"The sum of the primes below 10 is 2 + 3 + 5 + 7 = 17.

Find the sum of all the primes below two million.";
		public int ProblemNumber => 10;

		public string Solution()
		{
			return ProblemSolution(2000000).ToString();
		}

		private long ProblemSolution(int numbersBelow)
		{
			long ans = 0;
			for (var a = 2; a < numbersBelow; a++)
				ans += Dry.DryCode.IsPrime(a) ? a : 0;

			return ans;
		}

	}
}
