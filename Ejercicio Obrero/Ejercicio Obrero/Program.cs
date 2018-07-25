using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Obrero
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingresa las horas trabajadas");
            String horasT = Console.ReadLine();
            int horas = int.Parse(horasT);
            if (horas < 40)
            {
                horas = horas * 16;
                Console.WriteLine("Las horas trabajadas son menos de 40 y equivalen a ${0}", horas);
            }
            else
            {
                horas = horas - 40;
                int horasextra = horas * 20;
                Console.WriteLine("Las horas trabajadas pagadas a 16 pesos son 40 y equivalen a $640");
                Console.WriteLine("Las horas extra pagadas a 20 fueron {0}", horas);
                Console.WriteLine("y equivalen a ${0},", horasextra);
            }
            Console.ReadLine();
        }
    }
}
