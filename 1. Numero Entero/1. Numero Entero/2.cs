using System;

namespace _2._Mayor_de_dos_Enteros
{
    class Program
    {
        static void Main(string[] args)
        {
            //Jannabel Ramos Ramirez 2019-8510
            //Crear un programa que pida al usuario dos números enteros y diga cuál es el
           // mayor de ellos



            Console.Write(" \n ~ Ingrese un numero entero: ");
            int n1 = Convert.ToInt32(Console.ReadLine());
            Console.Write(" \n ~ Ingrese otro numero entero: ");
            int n2 = Convert.ToInt32(Console.ReadLine());


            if(n1>n2) Console.Write(" \n ~ {0} Es el mayor ~ ", n1);
            if (n2 > n1) Console.Write(" \n ~ {0} Es el mayor~ ", n2);

            Console.ReadKey();
        }
    }
}
