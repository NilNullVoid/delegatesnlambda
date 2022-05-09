using System;

namespace delegatesnlambda
{
    class Program
    {
        static void Main(string[] args)
        {
            Action<string> Welcome = x => Console.WriteLine($"Welcome friend {x}");
            Welcome("John");
            Action<int, int> AddTwoNums = (x1, x2) => Console.WriteLine(x1 + x2);
            AddTwoNums(15, 16);
            Action<int[]> SumArr = x =>
            {
                int total = 0;
                foreach (int i in x) total += i;
                Console.WriteLine(total);
            };
            int[] test = { 5, 7, 3, 2, 9 };
            SumArr(test);
            Action<int, int> ComputePower = (b, e) =>
            {
                int total = b;
                for (int i = 0; i < e - 1; i++) total *= b;
                Console.WriteLine(total);
            };
            ComputePower(3, 2);
            Action<int> Fibbonaci = n =>
            {
                int firstnumber = 0, secondnumber = 1, result = 0;
                if (n == 0)
                {
                    Console.WriteLine(0);
                    return;
                }
                if (n == 1)
                {
                    Console.WriteLine(1);
                    return;
                }
                for (int i = 2; i <= n; i++)
                {
                    result = firstnumber + secondnumber;
                    firstnumber = secondnumber;
                    secondnumber = result;
                }
                Console.WriteLine(result);
            };
            Fibbonaci(10);
        }
    }
}
