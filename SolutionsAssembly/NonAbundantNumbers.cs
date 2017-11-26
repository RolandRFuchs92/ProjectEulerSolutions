using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SolutionsAssembly.Dry;

namespace SolutionsAssembly
{
    public class NonAbundantNumbers : ISolutionsContract
    {
        public string ProblemName => "Non-abundant Sums";
        public string ProblemDescription => 
@"A perfect number is a number for which the sum of its proper divisors is exactly equal to the number. For example, the sum of the proper divisors of 28 would be 1 + 2 + 4 + 7 + 14 = 28, which means that 28 is a perfect number.

A number n is called deficient if the sum of its proper divisors is less than n and it is called abundant if this sum exceeds n.

As 12 is the smallest abundant number, 1 + 2 + 3 + 4 + 6 = 16, the smallest number that can be written as the sum of two abundant numbers is 24. By mathematical analysis, it can be shown that all integers greater than 28123 can be written as the sum of two abundant numbers.However, this upper limit cannot be reduced any further by analysis even though it is known that the greatest number that cannot be expressed as the sum of two abundant numbers is less than this limit.

Find the sum of all the positive integers which cannot be written as the sum of two abundant numbers.";
        public int ProblemNumber => 23;
        public int _limmit = 28123;

        public string Solution()
        {
            return ProblemSolution();
        }

        private string ProblemSolution()
        {
            var abundantSums = 0;
            var abundantSumsList = GetAbundantSums(GetAbundantNumberList());
            for (int i = 0; i < _limmit; i++)
                abundantSums += !abundantSumsList.Contains(i) ? i : 0;

            return abundantSums.ToString();
        }

        private List<int> GetAbundantNumberList()
        {
            var abundantList = new List<int>();

            for (int i = 1; i < _limmit; i++)
            {
                if (DryCode.IsPrime(i)) continue;                                                   // if its a prime, move along. 
                var abund = Enumerable.Range(1, i / 2).Where(inc => i % inc == 0).ToArray();        
                if (abund.Sum() > i)                                                                // if the number is abundant, add to list
                    abundantList.Add(i);
            }
            return abundantList;
        }

        private List<int> GetAbundantSums(List<int> abundantList)
        {
            var abundantSums = new List<int>();

            for (int a = 0; a < abundantList.Count; a++)
                for (int b = 0; b < abundantList.Count; b++)
                    abundantSums.Add(abundantList[a] + abundantList[b]);

            return abundantSums.Distinct().ToList();
        }
    }
}
