using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica1
{
    public class Program
    {
        //Programa donde recibo dos valores de la consola
        //y verifico cuál de éstos es mayor
        //y de acuerdo a esto, mostrar un mensaje de cuál es el mayor
        static void Main(string[] args)
        {
            // <<<<<<<<<<<< CAPTURA DE DATOS >>>>>>>>>>>>>>>
            //declaro var con dos valores de tipo entero
            int valor1 = 0, valor2 = 0;
            //declaro una var de tipo cadena 
            //para poder recibir los valores de la consola
            string cadena;
            //El programa muestra un mensaje para pedir los datos
            Console.WriteLine("Dame el primer valor en números: ");
            //para recibir el valor utilizo el método
            //ReadLine para que me regrese una cadena
            //a través de una variable
            //Es decir la var Cadena va a ser igual a lo que regrese el objeto Console
            cadena = Console.ReadLine();
            //para evitar que se pierda el valor recibido, 
            //lo debo asignar a la 1ra var, a través del objeto de conversión 
            //Convert.ToInt32 - para convertir la cadena en entero
            //Si capturo una cadena que no tiene números el resultado será un error
            valor1 = Convert.ToInt32(cadena);
            //repito lo mismo para el segundo valor
            Console.WriteLine("Dame el segundo valor en números: ");
            cadena = Console.ReadLine();
            valor2 = Convert.ToInt32(cadena);

            // <<<<<<<<<<<< INDICAR CUÁL ES MAYOR >>>>>>>>>>>>>>>
            // Para indicar cuál es el mayor tengo que compararlo
            // para ello utilizo una bucle de control if para evaluar 
            // una condición y a partir de ella realizar ciertas instrucciones
            // si se cumplen y sino hacer otras
            if (valor1 > valor2)
            {
                Console.WriteLine("Valor 1 es mayor que valor 2 ");
            }
            else if (valor1 == valor2)
            {
                Console.WriteLine("Valor 1 es igual a valor 2 ");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Valor 2 es mayor que valor 1 ");
                Console.ReadKey();
            }
        }
    }
}
