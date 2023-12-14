using System;

namespace MetodosAmbitosYScarga
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Suma(3, 5));
        }

        static int Suma(int op1, int op2) => op1 + op2;

        static int Suma(int op1, double op2) => op1 ;

        static int Suma(int op1, int op2, int op3) => op1 + op2 / op3;
    }
}

