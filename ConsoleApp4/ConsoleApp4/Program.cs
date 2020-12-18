using System;


namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("S=9,756y^7+2*tgx");
            Random rand = new Random();
            double x = rand.Next(0, 99);
            double y = rand.Next(0, 99);
            Console.WriteLine($"x={x}");
            Console.WriteLine($"y={y}");
            double result = Math.Tan(x);
            double result2 = Math.Pow(y,7);
            double S = 9.756*result2+2*result;
            Console.WriteLine($"S={S}");
            Console.ReadLine();
        }
    }
}
