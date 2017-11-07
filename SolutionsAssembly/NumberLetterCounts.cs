using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolutionsAssembly
{
	public class NumberLetterCounts: ISolutionsContract
	{
		public string ProblemName => "Number Letter Count";
		public string ProblemDescription => @"If the numbers 1 to 5 are written out in words: one, two, three, four, five, then there are 3 + 3 + 5 + 4 + 4 = 19 letters used in total.

If all the numbers from 1 to 1000 (one thousand) inclusive were written out in words, how many letters would be used?


NOTE: Do not count spaces or hyphens. For example, 342 (three hundred and forty-two) contains 23 letters and 115 (one hundred and fifteen) contains 20 letters. The use of 'and' when writing out numbers is in compliance with British usage.";
		public int ProblemNumber => 17;

		private static int[] SubTen => new int []{ 3, 3, 5, 4, 4, 3, 5, 5, 4}; //zero, one,two,three,four,five,six,seven,eight,nine
		private static int[] SubTwenty => new int[] { 3, 6, 6, 8, 8, 7, 7, 9, 8, 8 };//ten, eleven,twelve,thirteen,fourteen,fifteen,sixteen,seventeen,eighteen,nineteen
		private static int[] SubHundred=> new int[] { 6, 6, 5, 5, 5, 7, 6, 6 };//twenty,thirty,forty,fifty,sixty,seventy,eighty,ninety
		private static int[] HunThou => new int[] { 7, 8 }; //hundred, thousand


		public string Solution()
		{
			return ProblemSolution().ToString();
			//return NumberToWordCount(90).ToString();
		}

		private int ProblemSolution()
		{
			var answer = 0;
			for (int i = 1; i < 1001; i++)
			{
				answer += NumberToWordCount(i);
			}                                 
			return answer;
		}

		private int NumberToWordCount(int vocalizeNumber)
		{
			var wordPos = 0;
			var sumWordCount = 0;
			

			//handle thousand
			if ((vocalizeNumber / 1000) > 0)
			{
				sumWordCount += SubTen[vocalizeNumber/1000 -1]; //one
				sumWordCount += HunThou[1]; // thousand...
			}

			vocalizeNumber %= 1000;
			wordPos = (vocalizeNumber / 100);

			//handle hundreds
			if (wordPos > 0)
			{
				sumWordCount += SubTen[(vocalizeNumber/100) -1];
				sumWordCount += HunThou[0];
				sumWordCount +=  (vocalizeNumber % 100) > 0 ? 3: 0; //and
			}
			vocalizeNumber %= 100;

			//handle sub 100
			if (vocalizeNumber == 0)
				return sumWordCount;
			if (vocalizeNumber % 10 ==0 && vocalizeNumber >10) //more then 10 and no remainders
				return sumWordCount += SubHundred[(vocalizeNumber / 10) - 2];
			else if (vocalizeNumber < 10) // less then 10 
				return sumWordCount += SubTen[vocalizeNumber%10 -1];
			else if (vocalizeNumber > 9 && vocalizeNumber < 20) // between 9 and 20
				return sumWordCount += SubTwenty[(vocalizeNumber - 10) % 10];
			else //has a 10 and a digit
			{
				sumWordCount += SubHundred[(vocalizeNumber / 10)-2 ];
				return sumWordCount += SubTen[(vocalizeNumber % 10)-1];
			}
		}

	}
}
