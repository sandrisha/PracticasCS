using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TutorialesCS
{
    class Program
    {
        static void Main(string[] args)
        {
            // JERARQUIA DE OPERADORES
            double valor1 = 1.5;
            double valor2 = 3.7;
            double valor3 = 6.7;
            double resultado = 0.0;

            resultado = 5 + 6 * 2;
            Console.WriteLine("El resultado es: " + resultado);

            resultado = (5 + 6) * 2;
            Console.WriteLine("El resultado es: " + resultado);

            resultado = ((valor1 + valor2) * (valor2 / valor3));
            Console.WriteLine(resultado);
            Console.ReadKey();
        }
    }
}
