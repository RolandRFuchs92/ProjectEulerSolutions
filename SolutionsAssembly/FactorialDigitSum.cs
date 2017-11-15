using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace SolutionsAssembly
{
	public class FactorialDigitSum: ISolutionsContract
	{

		public string ProblemName => "Factorial Digit Sum";

		public string ProblemDescription =>
@"n! means n × (n − 1) × ... × 3 × 2 × 1

For example, 10! = 10 × 9 × ... × 3 × 2 × 1 = 3628800,
and the sum of the digits in the number 10! is 3 + 6 + 2 + 8 + 8 + 0 + 0 = 27.

Find the sum of the digits in the number 100!
";
		public int ProblemNumber => 20;

		public string Solution()
		{
			return Dry.DryCode.StringDigitSum(ProblemSolution(100)).ToString();
		}

		private string ProblemSolution(int starVal)
		{
			int finalVal = starVal;
			BigInteger moo = 100;

			for (int n = starVal; n > 1; n--)
				moo = BigInteger.Multiply(moo, (n - 1));

			return moo.ToString();
		}

		
	}
}
