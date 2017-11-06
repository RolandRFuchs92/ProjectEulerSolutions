using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolutionsAssembly
{
	public class PowerDigitSum : ISolutionsContract
	{
		public string ProblemName => "Power Digit Sum";
		public string ProblemDescription =>
@"215 = 32768 and the sum of its digits is 3 + 2 + 7 + 6 + 8 = 26.

What is the sum of the digits of the number 21000?";
		public int ProblemNumber => 16;

		public string Solution()
		{
			return ProblemSolution(1000).ToString();
		}

		private int ProblemSolution(int power)
		{
			string powerHolder = PowerCalculator(2, power);
			return DigitSum(powerHolder);
		}

		private string PowerCalculator(int coefficient,int powerOf)
		{
			string powerHolder = coefficient.ToString();
			int savedVal = 0;

			for (int power = 0; power < (powerOf-1); power++) //run through the current value "x" number of times
			{
				powerHolder = PowerResult(powerHolder);
			}

			return powerHolder;
		}

		private string PowerResult(string currentVal)
		{
			int savedVal = 0;
			string newVal = "";

			for (int pos = currentVal.Length; pos > 0 ; pos--)
			{
				int rightVal = int.Parse(currentVal[pos - 1].ToString());
				savedVal += rightVal + rightVal;
				newVal = (savedVal % 10).ToString() +newVal;
				savedVal /= 10;
			}

			newVal = savedVal + newVal;

			return CleansePrefixedZeros(newVal);
		}

		private string CleansePrefixedZeros(string val)
		{
			var checkLeft = 0;
			var inc = 0;
			while (checkLeft == 0)
			{
				checkLeft = int.Parse(val[inc].ToString());
				inc++;
			}

			return val.Substring(inc - 1);
		}

		private int DigitSum(string poweredVal)
		{
			int val = 0;
			foreach (var chr in poweredVal)
			{
				val += int.Parse(chr.ToString());
			}

			return val;
		}

	}
}
