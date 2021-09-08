using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1208ClaseTeorica
{
    class Program
    {
        public static void Main(string[] args)
        {
            //llamado al metodo loops
            loops();

            Console.ReadKey();
        }

        //bucles
        public static void loops()
        {
            int[] numbers = new int[3];
            numbers[0] = 5;
            numbers[1] = 10;
            numbers[2] = 15;

            //ciclo while
            int i = 0;
            Console.WriteLine("IMPRIME ELEMENTOS CON EL CICLO WHILE:");
            while (i < numbers.Length)
            {
                Console.WriteLine(numbers[i]);
                i++;
            }

            //ciclo do-while
            Console.WriteLine("\n");
            Console.WriteLine("IMPRIME ELEMENTOS CON EL CICLO DO-WHILE:");
            int inc = 0;
            do
            {
                Console.WriteLine(numbers[inc]);

                inc++;
            } while (inc < numbers.Length);

            //ciclo for
            Console.WriteLine("\n");
            Console.WriteLine("IMPRIME ELEMENTOS CON EL CICLO FOR:");
            for (int j = 0; j < numbers.Length; j++)
            {
                Console.WriteLine("Posicion {0} : {1}", j, numbers[j]);
            }

            //ciclo foreach
            Console.WriteLine("\n");
            Console.WriteLine("IMPRIME ELEMENTOS CON EL CICLO FOREACH:");

            foreach (int item in numbers)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();

            //ejercicio realizado en clase
            {
                int[] arraynumeros = new int[10];

                int sumaTotal = 0;
                double promedio;

                int n = 0;

                while (n < arraynumeros.Length)
                {
                    Console.WriteLine("Ingrese el valor en la posicion {0}", n);
                    arraynumeros[n] = Convert.ToInt32(Console.ReadLine());
                    n++;
                }

                Console.WriteLine("\n");

                Console.WriteLine("Mostrando datos del array ARRAYNUMEROS");

                int m = 0;
                Console.WriteLine("IMPRIME ELEMENTOS CON EL CICLO WHILE");
                while (m < arraynumeros.Length)
                {
                    Console.WriteLine(arraynumeros[m]);
                    m++;
                }

                Console.WriteLine();

                //calculando promedio
                for (int count = 0; count < 10; count++)
                {
                    sumaTotal = sumaTotal + arraynumeros[count];
                }
                promedio = sumaTotal / arraynumeros.Length;

                Console.WriteLine("El promedio de los datos ingresados es: {0}", promedio);

                Console.WriteLine("\n");

                Console.WriteLine("By: Bryan Martinez...");

            }
        }
    }
}