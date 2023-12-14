using System;

    namespace PildorasInformaticas1
{
    class Program
    {
        static void Main(string[] args)
        {
            mensajeEnPantalla();
            mensajeEnPantalla();

            Console.WriteLine("Hoolaaa mensaje principal");
        }

        static void mensajeEnPantalla()
        {
            int num1, num2;
            int i;

            int mat = 2;

            for(i = 0; i < mat; i++)
            {
                num1 = 1;
                num2 = 6;

                int resultado;

                resultado = num2 + num1;

                Console.WriteLine("ingresa el primer numero");
                num1 = int.Parse(Console.ReadLine());

                Console.WriteLine("ingresa el segundo numero");
                num2 = int.Parse(Console.ReadLine());

                if (num1 == num2)
                {
                    Console.WriteLine(num1 + num2);
                }
                else
                {
                    Console.WriteLine(num1 / num2 * +resultado);
                }

            }
        }
    }
}