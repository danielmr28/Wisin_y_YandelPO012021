using System;

namespace ejemplo1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a=0;
            int b=0;
            int sum =0;
            Console.WriteLine("Ingrese un número");
            a=int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese otro número");
            b=int.Parse(Console.ReadLine());
            sum = a + b ;
            Console.WriteLine("La suma es "+ $"{sum}");
        
        }
    }
}
