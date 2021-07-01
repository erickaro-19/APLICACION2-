using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicacion_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduce uno de los siguientes numeros.");
            Console.WriteLine("");
            Console.WriteLine("1 - Suma");
            Console.WriteLine("2 - Resta");
            Console.WriteLine("3 - Multiplicación");
            Console.WriteLine("4 - División");
            Console.WriteLine("");

            int numero = int.Parse(Console.ReadLine());

            int n1 = 0;
            int n2 = 0;

            if (numero != 1)
            {
                if (numero != 2)
                {
                    if (numero != 3)
                    {
                        if (numero != 4)
                        {
                            return;
                        }
                    }
                }
            }
            Console.WriteLine("Escribe el primero numero");
            try
            {
                n1 = int.Parse(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Ocurrio un error");
            }
            Console.WriteLine("Escribe el segundo numero");
            try
            {
                n2 = int.Parse(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Ocurrio un error");
            }

            if (numero == 1)
            {
                int suma = n1 + n2;
                Console.WriteLine("El total de la suma es: " + suma);
            }
            if (numero == 2)
            {
                int resta = n1 - n2;
                Console.WriteLine("El total de la suma es: " + resta);
            }

            if (numero == 3)
            {
                int multiplicación = n1 * n2;
                Console.WriteLine("El total de la suma es: " + multiplicación);
            }
            if (numero == 4)
            {
                int division = n1 / n2;
                Console.WriteLine("El total de la suma es: " + division);
            }


            Console.ReadKey();

        }
    }
}
