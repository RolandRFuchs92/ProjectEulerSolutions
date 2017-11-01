using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolutionsAssemblyConsoleTest
{
    class ConsoleInteractions
    {
        /// <summary>
        /// Display a list of available solutions
        /// </summary>
        /// <returns>Read user input</returns>
        public static void IntroductionMessage()
        {
            var solutions = new SolutionList().solutionList;
            foreach (var solution in solutions)
            {
                Console.WriteLine($"{solutions.IndexOf(solution) + 1}) {solution.ProblemName}");
            }

        }


        public static void SelectAnOption(string userSelection)
        {
            int index;
            bool validSelection = int.TryParse(userSelection, out index);
            var solution = new SolutionList().solutionList;
            
            if (validSelection && --index < solution.Count)
            {
                Console.Clear();
                Console.WriteLine($"{index}) {solution[index].ProblemName}\r\n\r\n");
                Console.WriteLine(solution[index].ProblemDescription + "\r\n\r\n");
                Console.WriteLine($"The answer is :\r\n {solution[index].Solution()}");
                Console.ReadKey();
            }
        }
    }
}
