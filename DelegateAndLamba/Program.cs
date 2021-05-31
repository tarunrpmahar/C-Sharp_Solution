using System;

namespace DelegateAndLamba
{
    class Program
    {
        static void Main(string[] args)
        {
            MathOpDelegate f = Add;
            //f = Substract;

            Console.WriteLine(f(21, 21));

            CalculateAndPrint(21, 21, Substract);

            CalculateAndPrint(21, 21, delegate (int x, int y) { return (x + y); });

            //lambdas 
            CalculateAndPrint(21, 21, (int x, int y) => x - y);
            // OR
            CalculateAndPrint(21, 21, (x, y) => x * y);
        }

        delegate int MathOpDelegate(int x, int y);

        static void CalculateAndPrint(int x, int y, MathOpDelegate f)
        {
            Console.WriteLine(f(x, y));
        }
        static int Add(int x, int y)
        {
            return x + y;
        }

        static int Substract(int x, int y)
        {
            return x - y;
        }
    }
}
