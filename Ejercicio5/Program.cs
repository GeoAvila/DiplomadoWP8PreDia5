using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Dynamic;
namespace Ejercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
            //var numeros = Enumerable.Range(1,1000);

            ////var pares = from n in numeros
            ////            where n % 2 == 0
            ////            select n * n;
            //var pares = numeros.Where(n => n % 2 == 0).ToArray();
            //foreach (var n in pares)
            //{
            //    Console.WriteLine(n);
            //}
            //Console.ReadKey();
            dynamic obj = new ExpandoObject();
            obj.Mipropiedad = "Hola";
            obj.OtraPropiedad = 3.1416;
            Console.WriteLine(obj.OtraPropiedad);
            
        }
    }
}
