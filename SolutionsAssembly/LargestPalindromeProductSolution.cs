using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolutionsAssembly
{
	public class LargestPalindromeProductSolution : ISolutionsContract
	{
		/// <summary>
		/// C# 6 lets to use expression bodies
		/// </summary>
		public string ProblemName => "Largest Palindrome Product"; 
		public string ProblemDescription => "A palindromic number reads the same both ways. The largest palindrome made from the product of two 2-digit numbers is 9009 = 91 × 99.\r\n\r\n" +
																				"Find the largest palindrome made from the product of two 3 - digit numbers.";
		public int ProblemNumber => 4;
		

		public long Solution()
		{
			return (long)ProblemSolution();
		}

		private int ProblemSolution()
		{
			int ans = 0, temp;
			int digitMin = 100, digitMax = 1000;

			for (var outer = digitMin; outer < digitMax; outer++)
				for (var inner = digitMin; inner < digitMax; inner++)
				{
					temp = palidroneNumber(inner * outer);
					ans = ans > temp ? ans : temp;
				}

			return ans;
		}

		/// <summary>
		/// Takes the product of a number, checks if the length can be halved
		///		if so, compare 2 halves of string return the product else return 0
		///		if not return 0 
		/// </summary>
		/// <param name="product"></param>
		/// <returns></returns>
		private int palidroneNumber(int product)
		{
			var productString = product.ToString();
			var halfString = productString.Length / 2;

			if (productString.Length % 2 == 0)
			{
				return productString.Substring(0, halfString) == reverseString(productString.Substring(halfString, halfString))
								? product
								: 0;
			}
			else
				return 0;
		}

		/// <summary>
		/// reverse the string
		/// </summary>
		/// <param name="palidronString">pass in a string to be reversed</param>
		/// <returns></returns>
		private string reverseString(string palidronString)
		{
			return new string(palidronString.Reverse().ToArray());
		}

	}
}
