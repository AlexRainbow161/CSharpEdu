using System;

namespace ConsoleInputOutput
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Пожалуйста, введите свое имя или что угодно на свой вкус: ");

            string userInput = Console.ReadLine();
            
            Console.WriteLine("Привет! " + userInput);

            Console.Write("Введи число от 1 до 10, а попробую угадать его.: ");

            bool parsed = int.TryParse(Console.ReadLine(), out int userInputInt);

            if (parsed && userInputInt >= 1 && userInputInt <= 10) 
            {
                Console.WriteLine("Ты загадал число " + userInputInt + ". Зацени какой я ностердамус!");
            }
            else if (!parsed)
            {
                Console.WriteLine("Ты меня обманул, это не число!");
            }
            else
            {
                Console.WriteLine("Не жульничай, я все вижу! Ты ввел не то число о котором мы договаривались");
            }

            
        }
    }
}