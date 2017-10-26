using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolutionsAssembly
{
    public class LargestPrimeFactorSolution : ISolutionsContract
    {
        public string ProblemName {
            get { return "Largest Prime Factor"; }
        }
        public string ProblemDescription {
            get { return "The prime factors of 13195 are 5, 7, 13 and 29.\r\n" +
                            "What is the largest prime factor of the number 600851475143?"; }
        }
        public int ProblemNumber { get { return 3; } }

        public int Solution()
        {
            return ProblemSoltion();
        }

        private int ProblemSoltion()
        {
            long aim = 600851475143, inc = 1, ans = 1;
            int result = 0;
            while (ans < aim)
            {
                if (aim % inc == 0)
                {
                    ans *= inc;
                    result = Convert.ToInt32(inc);
                }
                     
                inc++;
            }
            return result;
        }

    }
}
