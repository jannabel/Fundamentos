using System;

namespace _6._Division_de_dos_numeros
{
    class Program
    {
        static void Main(string[] args)
        {
            //Jannabel Ramos Ramirez 2019-8510
            /*Crear un programa que pida al usuario dos números enteros. Si el segundo no
            es cero, mostrará el resultado de dividir entre el primero y el segundo. Por el
            contrario, si el segundo número es cero, escribirá Error: No se puede dividir
            entre cero.*/

            int n1, n2;

            
            Console.Write(" \n ~ Ingrese un numero entero: ");
             n1 = Convert.ToInt32(Console.ReadLine());
             Console.Write(" \n ~ Ingrese un otro numero entero: ");
             n2 = Convert.ToInt32(Console.ReadLine());

            if (n2 != 0)
            {

                Console.WriteLine("\n ~ El resultado de la division es: " + n1/n2);
            }
              
            else
            {
                Console.Write(" \n ~ Error: No se puede dividir entre cero ~ ");
            }
            Console.ReadKey();
            }
        }
    }
