using System;

namespace _1._Numero_Entero
{
    class Program
    {
        static void Main(string[] args)
        {
            //Jannabel Ramos Ramirez 2019-8510
            //Crear un programa que pida al usuario un número entero y diga si es par.
            
           

            Console.Write(" \n ~ Ingrese un numero entero: ");
            int n = Convert.ToInt32(Console.ReadLine());
            if (n%2==0) Console.WriteLine("\n ~ El numero es par  ~" );
            Console.ReadKey();


        }
    }
}
