using System;

namespace Delegates
{
    class Program
    {
        static void Main(string[] args)
        {
            Predicate<int> predicate = IsPrime;

            for (int i=2; i<50; i++)
            {
                if(predicate(i)) Console.Write(i + " ");
            }
            Console.ReadKey();
        }

        static bool IsPrime(int n)
        {
            for(int i=2; i<=Math.Sqrt(n); i++)
            {
                if (n % i == 0) return false;
            }
            return true;
        }
        public static bool IsEven(int number, int number1) => number % 2 == 0;
    }
}