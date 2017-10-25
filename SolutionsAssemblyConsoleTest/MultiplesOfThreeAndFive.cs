using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using SolutionsAssembly;


namespace SolutionsAssemblyConsoleTest
{
    public class MultiplesOfThreeAndFive
    {
        public void showResult()
        {
            var solution = new MultiplesOfThreeAndFiveSolutions();
            Console.WriteLine(solution._getProblem);
            Console.WriteLine(solution.Solution());
            Console.ReadKey();
        }
    }
}