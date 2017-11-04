using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolutionsAssembly.Dry
{
	public class DryCode
	{
		/// <summary>
		/// Returns true if input is a prime number.
		/// </summary>
		/// <param name="number"></param>
		/// <returns></returns>
		public static bool IsPrime(int number)
		{
			return IsPrime((long)number);
		}

		public static bool IsPrime(long number)
		{
			if (number == 2) return true;
			if (number == 1 || number % 2 == 0) return false;
			var boundary = (int)Math.Floor(Math.Sqrt(number));

			for (var inc = 2; inc <= boundary; inc++)
				if (number % inc == 0)
					return false;

			return true;
		}

	}
}
