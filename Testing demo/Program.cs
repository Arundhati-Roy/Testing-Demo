using System;

namespace TestingDemo
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
        public int Add (int a, int b)
        {
            var sum = a + b;
            return sum;
        }
        public int Mul(int a,int b)
        {
            var prod = a * b;
            return prod;
        }
    }
}
