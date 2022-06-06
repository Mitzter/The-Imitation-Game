using System;

namespace ConsoleApp59
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();


            string command;
            while ((command = Console.ReadLine()) != "Decode")
            {
                string[] splitCommand = command.Split('|', StringSplitOptions.RemoveEmptyEntries);

                if (splitCommand[0] == "Move")
                {
                    string substring = input.Substring(0, int.Parse(splitCommand[1]));
                    input = input.Remove(0, int.Parse(splitCommand[1]));
                    input = input.Insert(input.Length, substring);
                }
                else if (splitCommand[0] == "Insert")
                {
                    int index = int.Parse(splitCommand[1]);
                    string value = splitCommand[2];

                    input = input.Insert(index, value);


                }
                else if (splitCommand[0] == "ChangeAll")
                {
                    string substring = splitCommand[1];
                    string replacement = splitCommand[2];

                    input = input.Replace(substring, replacement);
                }
            }
            Console.WriteLine($"The decrypted message is: {input}");
        }
    }
}