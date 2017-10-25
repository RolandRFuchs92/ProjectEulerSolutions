﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SolutionsAssembly
{
    public class MultiplesOfThreeAndFiveSolutions
    {
        public string _getProblem { get; }

       public  MultiplesOfThreeAndFiveSolutions()
        {
            _getProblem = @"If we list all the natural numbers below 10 that are multiples of 3 or 5, we get 3, 5, 6 and 9. The sum of these multiples is 23.\r\nFind the sum of all the multiples of 3 or 5 below 1000.";
        }

        public int Solution()
        {
            return ProblemSolution();
        }

        private int ProblemSolution()
        {            int answer = 0;
            
            for (int inc = 0; inc < 1000; inc++)
            {
                answer += (inc % 3) == 0 ? inc : inc % 5 == 0 ? inc : 0;
            }

            return answer;
        }
    }
}