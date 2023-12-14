using System;

namespace metodos_de_retorno
{
    class Program
    {
        static void Main(string[] args)
        {
              
            Console.WriteLine(sumaNumeros(2, 4));
            Console.WriteLine(restNumeros(2,4));
            Console.WriteLine(multNumeros(4, 8));
            Console.WriteLine(divNumeros(9, 3));

        }

        static int sumaNumeros(int num1, int num2)
        {
            return num1 + num2;
        }

        static int restNumeros(int num2, int num3)
        {
            return num3 - num2;
        }

        static int multNumeros(int num4,int num5)
        {
            return num4 * num5;
        }

        static int divNumeros(int num5, int num6)
        {
            return num5 * num6;
        }
    }
}
 