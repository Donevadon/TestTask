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
                bool result = handler.Check(message);
                Console.WriteLine("Корректность ввода : " + result);
            }
        }
    }
}
