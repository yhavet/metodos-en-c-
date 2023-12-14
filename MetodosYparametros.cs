using System;

namespace Metodos_Y_Parametros
{
    class Program
    {
        static void Main(string[] args)
        {
            SumarNumeros(7,9);
        }

        static void SumarNumeros(int num1, int num2)
        {

            Console.WriteLine("Ingrese el primer parametro");
            num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el segundo parametro parametro");
            num2 = int.Parse(Console.ReadLine());

            Console.WriteLine("parametro sumando" + (num1+num2 * num2 / 5));

        }
    }
}


