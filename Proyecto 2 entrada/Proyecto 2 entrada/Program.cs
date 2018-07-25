using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_2_entrada
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escriba la longiTud");
            string l = Console.ReadLine(); // CAPTURA DATOS POR TECLADO ()FUNCION
            double L = double.Parse(l); // PARCEAR  ES CAMBIAR EL TIPO DE DATO // PROCESO MATEMATICO
            Console.WriteLine("el valor es {0}", L);


            Console.WriteLine("Ingrese un numero 1 : ");
              string num1 = Console.ReadLine();
              int num1Parseado = int.Parse(num1);
              Console.Write("Ingrese numero 2:  ");
              string num2 = Console.ReadLine();
              int num2Parseado = int.Parse(num2);
              Console.WriteLine(" la suma es {0}", num1Parseado + num2Parseado);
                if (num1Parseado >num2Parseado){
                Console.WriteLine(" El primer numero es mayor ");
                }
                else {
                Console.WriteLine(" El primer numero es mayor ");
                }

               Console.WriteLine("ingrese numero 1 ");
               String n = Console.ReadLine();

               int nParseado = int.Parse(n);

                  Console.Write("ingrese numero 2 :");
                  String n2 = Console.ReadLine();
                  int n2Parseado = int.Parse(n2);
                 Console.WriteLine("la multiplicacion es  {0}", nParseado * n2Parseado);
                 Console.ReadKey();
        }
    }
}
