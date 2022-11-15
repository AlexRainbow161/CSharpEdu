using System;

namespace ConsoleInputOutput
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Пожалуйста, введите свое имя или что угодно на свой вкус: ");
            string userInput = Console.ReadLine();
            Console.WriteLine(userInput);
        }
    }
}