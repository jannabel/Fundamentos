using System;

namespace _3._Multiplo_de_un_numero
{
    class Program
    {
        static void Main(string[] args)
        {
            //Jannabel Ramos Ramirez 2019-8510
            //Crear un programa que pida al usuario dos números enteros y diga si el primero
            //es múltiplo del segundo

            Console.Write(" \n ~ Ingrese un numero entero: ");
            int n1 = Convert.ToInt32(Console.ReadLine());
            Console.Write(" \n ~ Ingrese otro numero entero: ");
            int n2 = Convert.ToInt32(Console.ReadLine());

            if (n1 % n2 == 0) Console.WriteLine("\n ~ El numero es multiplo  ~");
            Console.ReadKey();


        }
    }
}