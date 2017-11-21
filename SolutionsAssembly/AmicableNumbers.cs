using System;
using System.Collections.Generic;
using System.Linq;
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
			return ProblemSolution().ToString();
		}

		private long ProblemSolution()
		{
			long total = 0;
			for (int n = 2; n < 10000; n++)
			{
				int [] a = FindAmicableNumber(n);
				total += a != null ? a.Sum() : 0;
			}
				

			return total;
		}

		private int[] FindAmicableNumber(int n)
		{
			int [] amicableNumbers = FindEulerAmicableNumber(n)?? FindQurraAmicableNumber(n);
			return amicableNumbers;
		}

		#region Use Ammicable Theorems
		private int[] FindEulerAmicableNumber(int n)
		{
			int[] amicablePair = new int[2];
			var eulerP = GetEulerPValue(n);//Figure out Delegates and use them here, this can all be 1 function...
			var eulerQ = GetEulerQValue(n);//Figure out Delegates and use them here, this can all be 1 function...
			var eulerR = GetEulerRValue(n);//Figure out Delegates and use them here, this can all be 1 function...

			if (IsPrimeQPRValues(eulerP, eulerQ, eulerR))
			{
				amicablePair[0] = (int)Math.Pow(2, n) * eulerP * eulerQ;
				amicablePair[1] = (int)Math.Pow(2, n) * eulerR;

				Console.WriteLine($"Amicable Numbers > {amicablePair[0]} > {amicablePair[1]}");
				return amicablePair;
			}
			return null;
		}

		private int[] FindQurraAmicableNumber(int n)
		{
			int[] amicablePair = new int[2];
			var qurraP = GetQurraPValue(n);//Figure out Delegates and use them here, this can all be 1 function...
			var qurraQ = GetQurraQValue(n);//Figure out Delegates and use them here, this can all be 1 function...
			var qurraR = GetQurraRValue(n);//Figure out Delegates and use them here, this can all be 1 function...

			if (IsPrimeQPRValues(qurraP, qurraQ, qurraR))
			{
				amicablePair[0] = (int)Math.Pow(2, n) * qurraP * qurraQ;
				amicablePair[1] = (int)Math.Pow(2, n) * qurraR;

				Console.WriteLine($"Amicable Numbers > {amicablePair[0]} > {amicablePair[1]}");
				return amicablePair;
			}
			return null;
		}
		#endregion

		#region Thabit ibn Qurra Theorem 
		private int GetQurraPValue(int n)
		{
			return (int)(3 * Math.Pow(2, n - 1) - 1);
		}


		private int GetQurraQValue(int n)
		{
			return (int) (3 * Math.Pow(2, n) - 1);
		}

		private int GetQurraRValue(int n)
		{
			return (int) (3 * Math.Pow(2, 2 * n - 1) - 1);
		}
		#endregion

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
