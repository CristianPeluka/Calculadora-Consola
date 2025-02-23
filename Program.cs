using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraConsola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n1, n2;
            string operacion;
            Console.Write("Ingrese el primer numero: ");
            n1 = int.Parse(Console.ReadLine());

            Console.Write("Ingrese el segundo numero: ");
            n2 = int.Parse(Console.ReadLine());

            Console.WriteLine("1. + \n2. - \n3. * \n4. /");
            Console.Write("Seleccione la operacion a realizar: ");
            operacion = Console.ReadLine();

            switch (operacion)
            {
                case "1": Suma(n1, n2); break; // metodo para la suma
                case "2": Resta(n1, n2); break; // metodo para la resta
            }


        }

        public static void Suma(int n1, int n2)
        {
            Console.WriteLine($"La suma de los dos numeros es {n1 + n2}");
        }

        public static void Resta(int n1, int n2)
        {
            Console.WriteLine($"La resta de los dos numero es {n1 - n2}");
        }
    }
}
