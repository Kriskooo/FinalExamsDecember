using System;
using System.Collections.Generic;
using System.Linq;

namespace FinalExam
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            List<string> command = Console.ReadLine().Split(">>>").ToList();

            while (command[0] != "Generate")
            {
                if (command[0] == "Contains")
                {
                    string key = command[1];
                    if (input.Contains(key))
                    {
                        Console.WriteLine($"{input} contains {key}");
                    }
                    else
                    {
                        Console.WriteLine("Substring not found!");
                    }

                }
                else if (command[0] == "Flip")
                {
                    if (command[1] == "Lower")
                    {
                        int indexLenght = int.Parse(command[3]) - int.Parse(command[2]);
                        var cuttetPart = input.Substring(int.Parse(command[2]), indexLenght);
                        cuttetPart.ToLower();
                        input.Insert(int.Parse(command[2]), cuttetPart);
                    }
                    else if (command[1] == "Upper")
                    {
                        int indexLenght = int.Parse(command[3]) - int.Parse(command[2]);
                        var cuttetPart = input.Substring(int.Parse(command[2]), indexLenght);
                        cuttetPart = cuttetPart.ToUpper();
                        input = input.Remove(int.Parse(command[2]), indexLenght);
                        input = input.Insert(int.Parse(command[2]), cuttetPart);

                    }
                    Console.WriteLine(input);

                }
                else if (command[0] == "Slice")
                {

                }

                command = Console.ReadLine().Split(">>>").ToList();
            }

        }
    }
}

