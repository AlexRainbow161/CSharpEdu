using System;

namespace BaseTypes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            byte @byte = 255;

            short @short = 0;

            int @int = 0;

            long @long = 0;

            char @char = 'c';

            DateTime @datetime = DateTime.Now;

            DateTimeOffset @datetimeOffset = DateTimeOffset.Now;

            TimeSpan timeSpan = TimeSpan.Parse("17:17:08");

            object @object = new object();
            string @string = "Привет, Мир!";

            //Console.WriteLine(@byte);
            //Console.WriteLine(@short);
            //Console.WriteLine(@int);
            //Console.WriteLine(@long);
            //Console.WriteLine(@char);
            //Console.WriteLine(@string);
            //Console.WriteLine(datetime);
            //Console.WriteLine(datetimeOffset);
            //Console.WriteLine(timeSpan);
            //Console.WriteLine(@object);

            //Console.WriteLine("Math ops");

            //int i = 4 + 6;
            //Console.WriteLine(i);
            //byte b = 1 + 1;
            //Console.WriteLine(b);
            //Console.WriteLine('A' + 3);
            //Console.WriteLine(@datetime - timeSpan);

            //Приведение типов

            char a = 'a';
            int char_a_int = a;

            byte b = 1;
            int int_byte_b = b;
            /*
             * 0 и 1
             *     128 64 32 16 8 4 2 1
             * 0 0 0   0  0     1 0 0 1
             */
            int bigInt = 286;
            byte byte_big_int = (byte)bigInt; 

            Console.WriteLine(byte_big_int);

            ////Деление бывает обычное и по модулю.

            //int d = 5 / 2;
            //int modulus = 5 % 2;

            //double doubl = 2.5d;
            //float flt = 2.5f;
            //decimal dec = 2.5m;

            //var divide = 5.0m / 2.0m;

            //Console.WriteLine("Резултат деления 5 на 2 = " + divide);
            //Console.WriteLine("Резултат деления по модулю 5 на 2 = " + modulus);

            ////Конкатенация строк

            //string concat = "Строка 1 " + "Строка 2";
            //Console.WriteLine(concat);
        }
    }
}