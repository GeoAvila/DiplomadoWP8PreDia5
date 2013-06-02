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

            //var pares = from n in numeros
            //            where n % 2 == 0
            //            select n * n;
            var pares = numeros.Where(n => n % 2 == 0).Select(n => new MiClase {MyProperty = n.ToString() }).Select(c => int.Parse(c.MyProperty));
            foreach (var n in pares)
            {
                Console.WriteLine(n);
            }
            Console.ReadKey();
            
        }
    }
    public class MiClase
    {
        public string MyProperty { get; set; }
        public MiClase()
        {

        }
    }
}
