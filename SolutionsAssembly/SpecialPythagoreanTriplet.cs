using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolutionsAssembly
{
	public class SpecialPythagoreanTriplet : ISolutionsContract
	{
		public string ProblemName => "Special Pythagorean Triplet";

		public string ProblemDescription =>
			@"A Pythagorean triplet is a set of three natural numbers, a < b < c, for which,

a2 + b2 = c2
For example, 32 + 42 = 9 + 16 = 25 = 52.

There exists exactly one Pythagorean triplet for which a + b + c = 1000.
Find the product abc.";

		public int ProblemNumber => 9;

		public string Solution()
		{
			return ProblemSolution().ToString();
		}


		private int ProblemSolution()
		{
			var FinalSum = 1000;
			var max = FinalSum/2;

			for (var a = 1; a < max; a++)
				for (var b = a; b < max; b++)
				{
					var answer = productTripple(a, b, FinalSum);
					if (answer > 0) return answer;
				}

			return 0;
		}

		private int productTripple(int a, int b, int final)
		{
			var squareA = Math.Pow(a, 2);
			var squareB = Math.Pow(b, 2);
			var c = Math.Sqrt(squareA + squareB);

			if (c % 1 == 0)
				if (a + b + c == final)
					return a * b * (int)c;

			return 0;
		}
	}
}
