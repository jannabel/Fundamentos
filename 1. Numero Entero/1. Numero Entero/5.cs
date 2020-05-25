using System;

namespace _5._Producto_de_dos_numeros
{
    class Program
    {
        static void Main(string[] args)
        {
            //Jannabel Ramos Ramirez 2019-8510
            /*Crear un programa que multiplique dos números enteros de la siguiente forma:
            pedirá al usuario un primer número entero. Si el número que se que teclee es 0,
            escribirá en pantalla El producto de 0 por cualquier número es 0. Si se ha
            tecleado un número distinto de cero, se pedirá al usuario un segundo número y
            se mostrará el producto de ambos.*/

            int n1, n2;

            
            Console.Write(" \n ~ Ingrese un numero entero: ");
             n1 = Convert.ToInt32(Console.ReadLine());

            if (n1 != 0)
            {

                Console.Write(" \n ~ Ingrese un otro numero entero: ");
                n2 = Convert.ToInt32(Console.ReadLine());

                if (n2 != 0)
                {

                    Console.WriteLine("\n ~ El producto es: " + n1 * n2);

                }

                else
                {
                    Console.Write(" \n ~ El producto de 0 por cualquier número es 0 ~ ");
                }
            }
            else
            {
                Console.Write(" \n ~ El producto de 0 por cualquier número es 0 ~ ");
            }
            Console.ReadKey();
            }
        }
    }
