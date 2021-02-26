using System;
using System.Collections.Generic;
using System.Linq;

namespace ProblemFirst
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();

            List<string> commands = Console.ReadLine().Split().ToList();

            while (commands[0] != "Finish")
            {
                if (commands[0] == "Replace")
                {
                    word = word.Replace(commands[1], commands[2]);
                }
                else if (commands[0] == "Cut")
                {
                    int length = (int.Parse(commands[2]) + 1) - int.Parse(commands[1]);

                    if ((int.Parse(commands[1]) < 0 || int.Parse(commands[1]) >= word.Length) || (int.Parse(commands[2]) < 0 || int.Parse(commands[2]) >= word.Length))
                    {
                        Console.WriteLine("Invalid indices!");
                        commands = Console.ReadLine().Split().ToList();
                        continue;
                    }
                    else
                    {
                        word = word.Remove(int.Parse(commands[1]), length);
                    }
                }
                else if (commands[0] == "Make")
                {
                    if (commands[1] == "Upper")
                    {
                        word = word.ToUpper();
                    }
                    else if (commands[1] == "Lower")
                    {
                        word = word.ToLower();
                    }
                }
                else if (commands[0] == "Check")
                {
                    if (word.Contains(commands[1]))
                    {
                        Console.WriteLine($"Message contains {commands[1]}");
                    }
                    else
                    {
                        Console.WriteLine($"Message doesn't contain {commands[1]}");
                    }
                    commands = Console.ReadLine().Split().ToList();
                    continue;
                }
                else if (commands[0] == "Sum")
                {
                    if ((int.Parse(commands[1]) < 0 || int.Parse(commands[1]) >= word.Length) || (int.Parse(commands[2]) < 0 || int.Parse(commands[2]) >= word.Length))
                    {
                        Console.WriteLine("Invalid indices!");
                        commands = Console.ReadLine().Split().ToList();
                        continue;
                    }
                    else
                    {
                        int length = (int.Parse(commands[2]) + 1) - int.Parse(commands[1]);

                        var substring = word.Substring(int.Parse(commands[1]), length);

                        int sum = 0;
                        for (int i = 0; i < substring.Length; i++)
                        {
                            char currentChar = substring[i];

                            sum += currentChar;
                        }
                        Console.WriteLine(sum);
                        commands = Console.ReadLine().Split().ToList();
                        continue;
                    }
                }
                Console.WriteLine(word);
                commands = Console.ReadLine().Split().ToList();
            }
        }
    }
}
