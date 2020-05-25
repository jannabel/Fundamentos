using System;

namespace _4._Multiplos_de_10
{
    class Program
    {
        static void Main(string[] args)
        {
            //Jannabel Ramos Ramirez 2019-8510
            /*Crear un programa que pida al usuario un número entero. Si es múltiplo de 10,
            se lo avisará al usuario y pedirá un segundo número, para decir a continuación
            si este segundo número también es múltiplo de 10.*/

            Console.Write(" \n ~ Ingrese un numero entero: ");
            int n1 = Convert.ToInt32(Console.ReadLine());

            if (n1 % 10 == 0)
            {
                Console.WriteLine("\n ~ El numero es multiplo de 20 ~");
                Console.ReadKey();

                Console.Write(" \n ~ Ingrese otro numero entero: ");
                int n2 = Convert.ToInt32(Console.ReadLine());

                if (n2 % 10 == 0) Console.WriteLine("\n ~ El numero es multiplo de 10  ~");
            

            }
            Console.ReadKey();

            }
        }
    }
