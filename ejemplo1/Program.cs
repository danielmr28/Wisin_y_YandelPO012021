using System;

namespace ejemplo1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a=0;
            int b=0;
           
            Console.WriteLine("Enter value for a: ");
            a = Int32.Parse(Console.ReadLine());
           
            Console.WriteLine("Enter value for b: ");
            b = Int32.Parse(Console.ReadLine());
                        
            Console.WriteLine($"The solution of {a} x {b} equals = {MultiplyNumbers(a , b)} ");
        
        }

        public static int MultiplyNumbers(int a, int b)
        {
            return a * b;

        }
    }
}
