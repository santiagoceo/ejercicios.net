using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba_1_Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 123;
            decimal num2 = 1.34m;
            bool var3 = true;
            string cadena = "sadas";
            Console.WriteLine("el valor del entero es:{0} ", num1);
            Console.WriteLine("el valor del decimal es: {0}", num2);
            Console.WriteLine("el valor del bool es: {0}", var3);
            Console.WriteLine("el valor del string es: {0}", cadena);

            Console.ReadKey();
        }
    }
}
