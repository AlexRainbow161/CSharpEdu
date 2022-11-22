using System;

namespace Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] inputs = Console.ReadLine().Split(',');

            foreach (string input in inputs)
            {
                Console.WriteLine(input.Trim());
            }
        }
    }
}