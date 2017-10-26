using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolutionsAssembly
{
    public interface ISolutionsContract
    {
        int Solution();
        string ProblemName { get; }
        string ProblemDescription { get; }
        int ProblemNumber { get; }
    }
}
