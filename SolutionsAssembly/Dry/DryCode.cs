using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace SolutionsAssembly.Dry
{
	public class DryCode
	{
		/// <summary>
		/// Returns true if input is a prime number.
		/// </summary>
		/// <param name="number"></param>
		/// <returns></returns>
		public static bool IsPrime(int number)
		{
			return IsPrime((long)number);
		}

		public static bool IsPrime(long number)
		{
			if (number == 2) return true;
			if (number == 1 || number % 2 == 0) return false;
			var boundary = (int)Math.Floor(Math.Sqrt(number));

			for (var inc = 2; inc <= boundary; inc++)
				if (number % inc == 0)
					return false;

			return true;
		}

		/// <summary>
		/// Split a string into a 2DArray
		/// </summary>
		/// <param name="grid">String that is seperated by /n</param>
		/// <returns></returns>
		public static int[][] StringTo2DArray(string grid)
		{
			int[][] gridArray = grid.Split('\n')
															.Select
															(
																t => t.Split(' ')		//splits the new string lines by ' '  or spaces...
																.Select(int.Parse)	//parses all values to a string
																.ToArray()					//sets them to an array
															).ToArray();
			return gridArray;
		}

		/// <summary>
		/// Converts a grid to a specific 2D array in integer format.
		/// </summary>
		/// <param name="grid">The grid passed in string farmat, sperated by "\n"</param>
		/// <param name="groupingSize">The length of each string in grid column.</param>
		/// <returns></returns>
		public static int[][] StringTo2DArray(string grid, int groupingSize)
		{
			string[] rowArray = grid.Replace("\r","").Split('\n').ToArray();					//Cast the grid to multiple string rows.
			int[][] gridArray = new int[rowArray.Length][];         //instantiate the grid to the number of rows.

			foreach (var row in rowArray)                           //Run through each Row
			{
				int []arr = new int[row.Length];
				for (int i = 0; i < (row.Length / groupingSize); i++)//Run through each column in row
				{
					arr[i] = int.Parse(row.Substring(i * groupingSize, groupingSize)); //Add column value to column.
				}
				gridArray[Array.IndexOf(rowArray, row)] = arr;
			}	

			return gridArray;
		}

		/// <summary>
		/// Clears a string of new line and line feed characters
		/// </summary>
		/// <param name="cleanString">String to clear.</param>
		/// <returns></returns>
		public static string StringClean(string cleanString)
		{
			return Regex.Replace(cleanString, "\r", "").Replace("\n",""); ;
		}

		/// <summary>
		/// Returns an array of a devided string.
		/// </summary>
		/// <param name="stringToPart">String to split</param>
		/// <param name="length">Length of string parts</param>
		/// <returns></returns>
		public static string []StringParts(string stringToPart, int length)
		{
			string [] stringPart = new string[stringToPart.Length/length];
			int nextPart = 0;

			foreach (var chr in stringToPart)
			{
				stringPart[nextPart] += chr;
				nextPart = stringPart.Length == length ? 1 : 0;
			}

			return stringPart;
		}

		public static int StringDigitSum(string longNumberString)
		{
			int sumString = 0;
			foreach (var chr in longNumberString)
				sumString += int.Parse(chr.ToString());

			return sumString;
		}
	}
}
