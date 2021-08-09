using System;

namespace Ejercicio9_Signo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Este es el numero:"+Signo(0.1));
        }
        public static int Signo(double num)
        {
            int numeroEntero;
            if (num == 0)
            {
                return numeroEntero =0;
            }else if (num <= 0.0)
            {
                numeroEntero = -1;
                return numeroEntero;
            }
            else
            {
                numeroEntero = 1;
                return numeroEntero;
            }
           
        }
    }
}
