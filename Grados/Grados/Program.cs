using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grados
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Convertir Celsius a Fahrenheit

            // Variables
            double celsius = 38.3;
            double fahrenheit = 0.0;

            //Convertir
            fahrenheit = (celsius * 1.8) + 32;

            //Mostrar resultado
            Console.WriteLine("{0} C son {1} F", celsius, fahrenheit);
            Console.ReadKey();
        }
    }
}
