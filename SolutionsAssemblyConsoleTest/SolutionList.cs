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
            
        }

    }
}
