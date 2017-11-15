using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolutionsAssembly
{
	public class CountingSundays: ISolutionsContract
	{

		public string ProblemName => "Counting Sundays";
		public string ProblemDescription => 
@"You are given the following information, but you may prefer to do some research for yourself.

1 Jan 1900 was a Monday.
Thirty days has September,
April, June and November.
All the rest have thirty-one,
Saving February alone,
Which has twenty-eight, rain or shine.
And on leap years, twenty-nine.
A leap year occurs on any year evenly divisible by 4, but not on a century unless it is divisible by 400.
How many Sundays fell on the first of the month during the twentieth century (1 Jan 1901 to 31 Dec 2000)?";
		public int ProblemNumber => 19;
		public string Solution()
		{
			return ProblemSolution().ToString();
		}

		private int ProblemSolution()
		{
			int countSundays = 0;

			for (int year = 1901; year <= 2000; year++)
				for (int month = 1; month <= 12; month++)
						countSundays += new DateTime(year, month, 1).DayOfWeek == DayOfWeek.Sunday ? 1 : 0;

			return countSundays;
		}

	}
}
