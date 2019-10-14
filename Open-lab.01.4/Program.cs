using System;

namespace Open_lab._01._4
{
    class Program
    {
        
        static void Main(string[] args)
        {
            var siteA = Console.ReadLine();
            string height = Console.ReadLine();
            int a = int.Parse(siteA);
            int b = int.Parse(height);
            int c = a * b / 2;
            Console.WriteLine(c);
        }
    }
}
