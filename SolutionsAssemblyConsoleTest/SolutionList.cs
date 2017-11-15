using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SolutionsAssembly;

namespace SolutionsAssemblyConsoleTest
{
    class SolutionList
    {
        public List<ISolutionsContract> solutionList { get; set; }

        public SolutionList()
        {
            solutionList = new List<ISolutionsContract>();

            solutionList.Add(new MultiplesOfThreeAndFiveSolutions());
            solutionList.Add(new EvenFibonacciNumbersSolutions());
            solutionList.Add(new LargestPrimeFactorSolution());
            solutionList.Add(new LargestPalindromeProductSolution());
						solutionList.Add(new SmallestMultiple());
						solutionList.Add(new SumSquareDifference());
						solutionList.Add(new _10001stPrime());
						solutionList.Add(new LargestProductInASeries());
						solutionList.Add(new SpecialPythagoreanTriplet());
						solutionList.Add(new SummationOfPrimes());
						solutionList.Add(new LargestProductInAGrid());
						solutionList.Add(new HighlyDivisibleTriangularNumbers());
						solutionList.Add(new LargeSum());
						solutionList.Add(new LongestCollatzSequence());
						solutionList.Add(new LatticePath());
						solutionList.Add(new PowerDigitSum());
						solutionList.Add(new NumberLetterCounts());
						solutionList.Add(new MaximumPathSum1());
						solutionList.Add(new CountingSundays());
						solutionList.Add(new FactorialDigitSum());
        }

    }
}
