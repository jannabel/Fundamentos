using System;

namespace _8._Numeros_positivos { 
    class Program{
    static void Main(string[] args)
    {
        //Jannabel Ramos Ramirez 2019-8510
        /*Crear un programa que pida al usuario dos números enteros y diga Uno de los
        números es positivo, Los dos números son positivos o bien Ninguno de los
        números es positivo, según corresponda.*/

        Console.Write(" \n ~ Ingrese un numero entero: ");
        int n1 = Convert.ToInt32(Console.ReadLine());

        Console.Write(" \n ~ Ingrese un numero entero: ");
        int n2 = Convert.ToInt32(Console.ReadLine());

        if (n1 > 0 && n2 > 0) Console.WriteLine("\n ~ Ambos numeros son positivos ~");
       else if (n1 > 0 || n2 > 0) Console.WriteLine("\n ~ Uno de los numeros es positivo ~");
       else if (n1 < 0 && n2 < 0) Console.WriteLine("\n ~ Ninguno de los numeros es positivo ~");

        Console.ReadKey();

    }
}
}
