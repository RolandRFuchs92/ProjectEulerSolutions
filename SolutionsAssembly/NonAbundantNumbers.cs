using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public string Solution()
        {
            return ProblemSolution();
        }

        private string ProblemSolution()
        {
            return SumOfNonAbundantNumbers().ToString();
        }

        private long SumOfNonAbundantNumbers()
        {
            long total = 0;
            long abundantSum = AbundantListTotal();
            long integersSum = Enumerable.Range(1,28123).ToList().Sum();
            total = integersSum - abundantSum;

            return total;
        }

        private long AbundantListTotal()
        {
            var nonAbundantList = new List<int>();
            var abundantList = new List<int>();
            for (var n = 12; n < 28124; n++)
            {
                var abun = Enumerable.Range(1,n/2).Where(inc => n % inc == 0).ToList();
                var sumTotal = abun.ToArray().Sum();

                if (sumTotal > n)
                    abundantList.Add(n);
                else
                    continue;

                if (abundantList.Where(i => i == n / 2).FirstOrDefault() != 0)
                    continue;

                if (!NonPairedAbundantNumber(abundantList))
                    nonAbundantList.Add(n);
            }
            return abundantList.Sum() - nonAbundantList.Sum();
        }

        private bool NonPairedAbundantNumber(List<int> abundandList)
        {
            for (int outer = 0; outer < abundandList.Count -2; outer++)
            {
                for (int inner = 0; inner < abundandList.Count-2; inner++)
                {
                    if (outer==inner) continue;

                    if (abundandList[outer] + abundandList[inner] == abundandList[abundandList.Count - 1])
                    {
                        //using (StreamWriter sw = File.AppendText(@"C:/Temp/temp.txt"))
                        //    sw.WriteLine($"{abundandList[outer]},{abundandList[inner]},{abundandList[abundandList.Count - 1]}");

                        return true;
                    }
                }
            }
            return false;
        }

    }
}
