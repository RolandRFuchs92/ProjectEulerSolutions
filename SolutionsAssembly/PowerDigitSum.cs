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
			return ProblemSolution(10);
		}

		private string ProblemSolution(int power)
		{
			string powerHolder = PowerCalculator(2, power);
			return powerHolder;
		}

		private string PowerCalculator(int coefficient,int powerOf)
		{
			string powerHolder = coefficient.ToString();
			int savedVal = 0;

			for (int power = 0; power < powerOf; power++) //run through the current value "x" number of times
			{
				string tempPowerHolder = "";
				for (int span = powerHolder.Length; span > 0 || savedVal > 0; span--) //double the right most value for now
				{
					int RightMostValue = int.Parse(powerHolder[span-1].ToString());
					savedVal += (RightMostValue + RightMostValue);
					int savedValLen = savedVal.ToString().Length -1;
					tempPowerHolder = savedVal.ToString()[savedValLen].ToString() +tempPowerHolder;
					savedVal = savedValLen != 0 ?	 int.Parse(savedVal.ToString().Substring(0, savedValLen)) : 0;
				}
				powerHolder = tempPowerHolder;
			}

			return powerHolder;
		}
	}
}
