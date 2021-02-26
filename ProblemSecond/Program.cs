using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace ProblemSecond
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"![A-Z][a-z]{2,}!:\[([A-Za-z]{7,})\]";
            int count = int.Parse(Console.ReadLine());
            for (int i = 0; i < count; i++)
            {
                string input = Console.ReadLine();
                MatchCollection matches = Regex.Matches(input, pattern);
                if (matches.Count == 0)
                {
                    Console.WriteLine("The message is invalid");
                    continue;
                }
                List<int> intChar = new List<int>();
                foreach (Match message in matches)
                {
                    string arr = message.Groups[1].ToString();
                    for (int j = 0; j < arr.Length; j++)
                    {
                        intChar.Add((char)arr[j]);
                    }
                }
                Console.WriteLine(string.Join(" ", intChar));

            }
        }
    }
}
