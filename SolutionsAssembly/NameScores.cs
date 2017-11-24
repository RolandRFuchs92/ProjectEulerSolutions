using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;


namespace SolutionsAssembly
{
    public class NameScores : ISolutionsContract
    {
        public string ProblemName => "Name Scores";
        public string ProblemDescription =>
            @"Using names.txt (right click and 'Save Link/Target As...'), a 46K text file containing over five-thousand first names, begin by sorting it into alphabetical order. Then working out the alphabetical value for each name, multiply this value by its alphabetical position in the list to obtain a name score.

        For example, when the list is sorted into alphabetical order, COLIN, which is worth 3 + 15 + 12 + 9 + 14 = 53, is the 938th name in the list.So, COLIN would obtain a score of 938 × 53 = 49714.

        What is the total of all the name scores in the file?";
        public int ProblemNumber => 22;

        public string Solution()
        {
            return ProblemSoltution();
        }

        private string ProblemSoltution()
        {
            string[] nameList = ReadNamesList();
            int[] scoreList = ScoreNames(nameList);

            return scoreList.Sum().ToString();
        }

        private string[] ReadNamesList()
        {
            string routePath = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName;
            string namePath = $@"{routePath}\SolutionsAssembly\Resources\NameList.txt";
            var fileReader = new System.IO.StreamReader(namePath);

            return fileReader.ReadToEnd().Replace("\"", "").Split(',').OrderBy(i => i).ToArray();
        }

        private int[] ScoreNames(string []nameList)
        {
            int[]scoreName = new int[nameList.Length];

            for (int i = 0; i < nameList.Length; i++)
            {
                foreach (var chr in nameList[i])
                {
                    scoreName[i] += (chr-64);
                }
                scoreName[i] *= i + 1;
            }

            return scoreName;
        }
    }
}
