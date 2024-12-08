using System;

namespace For11
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int Sum = 0;
            for (int i = n; i <=2 * n; i++)
            {
                Sum = Sum + (i * i);
            }
            Console.WriteLine(Sum);
        }
    }
}