using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9.fórmulas_de_física_calcule_velocidad__tiempo_y_distancia
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Elija una opción de cálculo:"); //para que el usuario eliga que opcion quiere calcular,
            Console.WriteLine("1. Velocidad");
            Console.WriteLine("2. Tiempo");
            Console.WriteLine("3. Distancia");

            int choice = Convert.ToInt32(Console.ReadLine()); //Convierte la representación en forma de cadena de un número en el entero de 32 bits con signo equivalente

            switch (choice) //La switchinstrucción selecciona una lista de instrucciones para ejecutarse en función de una coincidencia de patrón con una expresión.
            {
                case 1:
                    Console.WriteLine("Ingrese la distancia recorrida");
                    double distance = Convert.ToDouble(Console.ReadLine()); 
                    Console.WriteLine("Ingrese el tiempo transcurrido");
                    double time = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("La velocidad es: " + distance / time + " m/s");
                    break;
               
                case 2:
                    Console.WriteLine("Ingrese la distancia recorrida");
                    distance = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Ingrese la velocidad");
                    double velocity = Convert.ToDouble(Console.ReadLine()); //convierte el valor.
                    Console.WriteLine("El tiempo es: " + distance / velocity + " s");
                    break; //salir de la funcion, si se cumple.
               
                case 3:
                    Console.WriteLine("Ingrese la velocidad"); 
                    velocity = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Ingrese el tiempo transcurrido");
                    time = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("La distancia recorrida es: " + velocity * time + " m"); //se realiza el calculo para obtener la opcion buscada
                    break;
               
                default:
                    Console.WriteLine("Opción inválida");
                    break;
            }
            Console.ReadLine(); //imprimir el resultado en pantalla,
        }
    }
}
