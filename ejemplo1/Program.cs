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

            Console.WriteLine("Enter valuo for b: ");
            b = Int32.Parse(Console.ReadLine());
            
            Console.WriteLine($"The solution of {a} - {b} equals = {AddNumbers(a , b)} ");
        
        }

        public static int AddNumbers(int a, int b)
        {
            return a - b;

        }
    }
}
