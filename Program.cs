using System;

namespace Exercicio_10
{
    class Program
    {
        static void Main(string[] args)
        {
            int w, x, y, z;
            bool a;
            Console.WriteLine("digite o valor de w: ");
            w = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("digite o valor de x: ");
            x = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("digite o valor de y: ");
            y = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("digite o valor de z: ");
            z = Convert.ToInt32(Console.ReadLine());

            a = ((x >= y) && (z <= x)) || ((x == w) && (y == z)) || (!(x != w));

            Console.WriteLine("O resultado da expressão é: " + a);
            Console.ReadKey();

        }
    }
}
