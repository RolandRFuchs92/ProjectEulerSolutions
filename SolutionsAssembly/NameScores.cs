using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolutionsAssembly
{
    public class NameScores : ISolutionsContract
    {
        public string ProblemName { get; }
        public string ProblemDescription { get; }
        public int ProblemNumber { get; }

        public string Solution()
        {
            throw new NotImplementedException();
        }

    }
}
