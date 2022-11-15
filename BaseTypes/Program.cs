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
            string @string = "Hello, World!";
            DateTime @datetime = DateTime.Now;
            DateTimeOffset @datetimeOffset = DateTimeOffset.Now;
            TimeSpan timeSpan = TimeSpan.Zero;
            object @object = new object();

            Console.WriteLine(@byte);
            Console.WriteLine(@short);
            Console.WriteLine(@int);
            Console.WriteLine(@long);
            Console.WriteLine(@char);
            Console.WriteLine(@string);
            Console.WriteLine(datetime);
            Console.WriteLine(datetimeOffset);
            Console.WriteLine(timeSpan);
            Console.WriteLine(@object);
        }
    }
}