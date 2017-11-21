using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace SolutionsAssembly
{
	public class AmicableNumbers :ISolutionsContract
	{
		public string ProblemName => "Amicable Numbers";

		public string ProblemDescription =>
@"Let d(n) be defined as the sum of proper divisors of n (numbers less than n which divide evenly into n).
If d(a) = b and d(b) = a, where a ≠ b, then a and b are an amicable pair and each of a and b are called amicable numbers.

For example, the proper divisors of 220 are 1, 2, 4, 5, 10, 11, 20, 22, 44, 55 and 110; therefore d(220) = 284. The proper divisors of 284 are 1, 2, 4, 71 and 142; so d(284) = 220.

Evaluate the sum of all the amicable numbers under 10000.
";
		public int ProblemNumber => 21;

		public string Solution()
		{
			return ProblemSolution(10000).ToString();
		}

		private long ProblemSolution(int max)
		{
			return IsAmicable(max);
		}


		private long IsAmicable(int max)
		{
			List<int> amicableList = new List<int>();

			for (var n = 1; n < max+1; n++)
			{
				if (amicableList.IndexOf(n) > 0) continue;											// if we have this number in the amicable list then proceed else skip

				var properSumList = ProperDevisors(n);													// get proper devisors
				if (properSumList.Count() < 3) continue;												// if prime skip
				var properSum = properSumList.Sum();

				if (properSum == n ) continue;
				var partnerSum = ProperDevisors(properSum).Sum();								// get the partner sum

				if (n != partnerSum) continue;																	// if they == then add to list else skip
					amicableList.Add(n);
					amicableList.Add(properSumList.Sum());
			}

			return amicableList.Sum();
		}

		private IEnumerable<int> ProperDevisors(int to)
		{
			return Enumerable.Range(1, to / 2).Where(divisor => to % divisor == 0).ToList(); ;
		}
		
		#region Euler's Rule

		private int GetEulerPValue(int n)
		{
			var m = n - 1;
			return (int)((Math.Pow(2, n - m) + 1) * Math.Pow(2, m) - 1); ;
		}

		private int GetEulerQValue(int n)
		{
			var m = n - 1;
			return (int)((Math.Pow(2, n - m) + 1) * Math.Pow(2, n) - 1);
		}

		private int GetEulerRValue(int n)
		{
			var m = n - 1;
			return (int)(Math.Pow((Math.Pow(2, n - m) + 1), 2) * Math.Pow(2, m + n) - 1);
		}

		#endregion

		private bool IsPrimeQPRValues(int p, int q, int r)
		{
			return Dry.DryCode.IsPrime(p) && Dry.DryCode.IsPrime(q) && Dry.DryCode.IsPrime(r);
		}

	}
}
