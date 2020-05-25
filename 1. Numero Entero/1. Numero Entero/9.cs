using System;

namespace _9._Mayor_de_tres_numeros
{
    class Program
    {
        static void Main(string[] args)
        {
            //Jannabel Ramos Ramirez 2019-8510
            /*Crear un programa que pida al usuario tres números reales y muestre cuál es el
              mayor de los tres.*/

            int n=0, mayor=0;

            for (int i = 1; i < 4; i++)
            {
                Console.Write(" \n ~Numero "+i+": ");
                n = Convert.ToInt32(Console.ReadLine());
               
                if (mayor < n)
                {
                    mayor = n;
                }
            }

            Console.WriteLine("\n ~ El mayor es: "+mayor);
            Console.ReadKey();

        }
    }
}
