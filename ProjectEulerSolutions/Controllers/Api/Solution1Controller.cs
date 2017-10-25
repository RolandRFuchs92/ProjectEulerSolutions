using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Mvc;
using ProjectEulerSolutions.Dto;
using SolutionsAssembly;

namespace ProjectEulerSolutions.Controllers.Api
{
    public class Solution1Controller : ApiController
    {
        public Solution1Dto Solution1()
        {
            var a = new MultiplesOfThreeAndFiveSolutions();
            var ans = new Solution1Dto
            {
                Answer = a.Solution(),
                Problem = a._getProblem
            };
            return ans;
        }
    }
}
