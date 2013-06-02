using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numeros = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            var pares = from n in numeros
                        where n % 2 == 0
                        select n;
            foreach (var n in pares)
            {
                Console.WriteLine(n);
            }
            Console.ReadKey();
        }
    }
}
