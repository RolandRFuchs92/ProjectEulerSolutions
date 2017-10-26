﻿using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace SolutionsAssembly
{
	public class EvenFibonacciNumbersSolutions : ISolutionsContract
	{
		/// <summary>
		/// C#6 Expression Bodies! yay!
		/// </summary>
		public string ProblemDescription => "Each new term in the Fibonacci sequence is generated by adding the previous two terms. By starting with 1 and 2, the first 10 terms will be:\r\n" +
										 "1, 2, 3, 5, 8, 13, 21, 34, 55, 89, ...\r\n" +
										 "By considering the terms in the Fibonacci sequence whose values do not exceed four million, find the sum of the even-valued terms.";
		public string ProblemName => "Even Fibanacci Number Product";
		public int ProblemNumber => 2;

		public int Solution()
		{
			return ProblemSolution();
		}

		private int ProblemSolution()
		{
			int ans = 0, firstNum = 0, secondNum = 1, currentNum = 0;

			while (currentNum < 4000000)
			{
				currentNum = firstNum + secondNum;
				firstNum = secondNum;
				secondNum = currentNum;

				ans += currentNum % 2 == 0 ? currentNum : 0;
			}
			return ans;
		}
	}
}
