using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Practico_WHILE
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ej 1: Ingresar varios números y sumarlos. Terminar cuando se ingresa el 0. Mostrar la 
            //suma de todos los números ingresados.

            Console.WriteLine("\n\n\t * Suma de número hasta ingresar 0 *\n");
            int num1 = 10;
            int suma = 0;
            while (num1 != 0)
            {
                try
                {
                    Console.Write("Ingrese un número: ");
                    num1 = Convert.ToInt32(Console.ReadLine());
                    suma = suma + num1;
                }

                catch
                {
                    Console.WriteLine("Lo ingresado no tiene formato numérico.");
                }
            }

            Console.Write("El suma de todos los valores ingresdos es: " + suma);

            //Otra manera de resolver es:
            /*Console.Write("Ingrese un número: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            int suma = num1;
            while (num1 != 0)
            {
                Console.Write("Ingrese otro número: ");
                num1 = Convert.ToInt32(Console.ReadLine());
                suma = suma + num1;
            }

            Console.Write("El suma de todos los valores ingresdos es: " + suma);*/



            //Ej 2: Ingresar varias palabras y concatenarlas. Terminar cuando me ingresen la cadena
            //vacía. Mostrar la frase armada.

            //Ej 3: Sabiendo que luego de las dos líneas de abajo, a contiene un valor aleatorio entre
            // 1 y 20, hacer un juego de "Adivine el número", de manera de preguntar el número hasta
            //que el usuario lo adivine, y en tal caso indicar que lo hizo
            Random a = new Random();
            int valor = a.Next(1, 21);

            Console.Write("\n\n\t* Adivine el número entre 1 y 20 *\n\n");
            Console.WriteLine(valor);

            Console.Write(" - Ingrese un número: ");
            num1 = Convert.ToInt32(Console.ReadLine());
            while (num1 != valor)
            {
                Console.Write("No hubo suerte!!!\n\n - Ingrese otro número: ");
                num1 = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("\n\n * * * Correcto, el número sorteado es: " + valor + " * * *");


            //Los siguientes ejercicios deben optar si los hacen con for o con while
            //Ej 4: Pedir una frase en consola, y mostrar la misma letra por letra una debajo de otra.

            //Ej 5: Idem al anterior, pero mostrar palabra por palabra.

            //Ej 6: Pedir un número de tres cifras y mostrar la unidad, la decena y la centena por 
            //separado. Solo se aceptan números de tres cifras y mientras el usuario no ingrese
            // un número correcto, se debe seguir preguntando. Usar try, por si el usuario ingresa
            //un valor no numérico.

            //Ej 7: Pedir dos números, almacenarlos en las variables num1 y num2. Intercambiar los
            //valores de las variables. Que el valor de num1 quede en num2 y el de num2 en num1.

            Console.ReadLine();
        }
    }
}
