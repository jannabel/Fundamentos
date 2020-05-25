using System;

namespace _7._Multiplos_de_5_o_4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Jannabel Ramos Ramirez 2019-8510
            /*Crear un programa que pida al usuario un número entero y diga si es múltiplo de 4 o de 5.*/

            Console.Write(" \n ~ Ingrese un numero entero: ");
            int n1 = Convert.ToInt32(Console.ReadLine());

            if (n1 % 4 == 0) Console.WriteLine("\n ~ El numero es multiplo de 4 ~");
            //en este caso, si el número resulta ser multiplo de 4 y de 5, se mostrarán ambas respuestas
            if (n1 % 5 == 0) Console.WriteLine("\n ~ El numero es multiplo de 5  ~");



            Console.ReadKey();

        }
    }
}
