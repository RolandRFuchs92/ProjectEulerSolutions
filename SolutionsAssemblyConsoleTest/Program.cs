﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using SolutionsAssembly;


namespace SolutionsAssemblyConsoleTest
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleInteractions.IntroductionMessage();
            ConsoleInteractions.SelectAnOption(Console.ReadLine());
        }
    }
}
