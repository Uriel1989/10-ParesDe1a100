using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _10_ParesDe1a100
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, a;
            a = 0;

            for (i = 1; i <= 100; i++)
            {



                if (i % 2 == 0)
                {

                    a = a + 1;
                    Console.WriteLine("Los numeros pares son: " + i);

                }
            }
            Console.WriteLine("La cantidad de numeros pares es de: " + a);
            Console.ReadKey();
        }
    }
}
