using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolutionsAssembly
{
    class MultiplesOfThreeAndFive
    {
        private readonly string _theProblem;

        MultiplesOfThreeAndFive()
        {
            _theProblem = @"If we list all the natural numbers below 10 that are multiples of 3 or 5, we get 3, 5, 6 and 9. The sum of these multiples is 23.

                            Find the sum of all the multiples of 3 or 5 below 1000.";
        }

        public int Solution()
        {
            int answer = 0;

            return answer;
        }

        private int ProblemLogic()
        {
            int answer = BasicProblemSolution(1000);

            return answer;
        }

        private int BasicProblemSolution(int checkNaturalSum)
        {
            int answer = 0;
            
            for (int inc = 0; inc < 1000; inc++)
            {
                answer += (inc % 3) == 0 ? inc : inc % 5 == 0 ? inc : 0;
            }

            return answer;
        }
    }
}
