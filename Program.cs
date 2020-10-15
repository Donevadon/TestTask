using System;

namespace TestTask
{
    class Program
    {
        static void Main(string[] args)
        {
            string message = null;
            IStringHandler handler = new Checker();
            while (true)
            {
                message = Console.ReadLine();
                Console.WriteLine(handler.Check(message));
            }
        }
    }
}
