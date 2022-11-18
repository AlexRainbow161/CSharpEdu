﻿using System;

namespace Calculator
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Log(message: "Введите выражение: ", withNewLine: false);

            var userInput = Console.ReadLine();

            args = userInput.Split(" ");

            if (args.Length > 3 || args.Length < 3)
            {
                Log("Внимание! Ошибка в выражении. Используйте простые выражения вида \"2 + 2\"");
                return;
            }

            try
            {
                int x = int.Parse(args[0]);
                int y = int.Parse(args[2]);
                string op = args[1];

                int result;

                switch (op)
                {
                    case "+":
                        result = Add(x, y);
                        break;
                    case "-":
                        result = Minus(x, y);
                        break;
                    case "*":
                        result = Multiply(x, y);
                        break;
                    case "/":
                        result = Devide(x, y);
                        break;
                    default:
                        result = 0;
                        break;
                }

                Log("Ваш ответ: " + result, false);
            }
            catch (FormatException)
            {
                Log("Неправильный формат числа.");
            }
            catch(Exception)
            {
                Log("Что то пошло не так.");
            }

            
        }

        private static void Log(string message, bool printDateTime = false, bool withNewLine = true)
        {
            if (printDateTime)
            {
                message = DateTime.Now + ": " + message;
            }

            if (withNewLine)
                Console.WriteLine(message);
            else
                Console.Write(message);
        }

        private static int Add(int x, int y) => x + y;
        private static int Minus(int x, int y) => x - y;
        private static int Multiply(int x, int y) => x * y;
        private static int Devide(int x, int y) => x / y;

    }
}