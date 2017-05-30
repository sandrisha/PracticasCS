using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Area
{
    class Program
    {
        static void Main(string[] args)
        {
            // CALCULAR EL ÁREA Y PERÍMETRO DE UN CUADRADO

            //Variables
            double lado = 5.0;
            double area = 0.0;
            double perimetro = 0.0;

            // CALCULAR EL AREA
            area = lado * lado;

            // CALCULAR EL PERIMETRO
            perimetro = lado * 4;

            // MOSTRAR RESULTADOS
            Console.WriteLine("El área de una cuadrado de lado {0} es {1}", lado, area);
            Console.WriteLine("El perímetro es {0}", perimetro);
            Console.ReadKey();
        }
    }
}
