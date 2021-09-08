using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1208ClaseTeorica
{
    class Ejemplo1
    {
        static void Main()
        {
            //diccionario.
            //almacena pares de datos clave y valor.
            //definir un diccionario.

            Dictionary<string, string> EmployeList = new Dictionary<string, string>();

            //Agregar elementos al diccionario
            EmployeList.Add("Jose Flores", "Programador");
            EmployeList.Add("Miranda Campos", "Generente");
            EmployeList.Add("Carmen Valladares", "Arquietecta");

            Dictionary<string, int> Students = new Dictionary<string, int>();
            Students.Add("Jose Flores", 20);
            Students.Add("Miranda Campos", 22);
            Students.Add("Carmen Valladares", 24);

            //leer el diccionario y mostrar los datos.
            foreach (KeyValuePair<string, string> employee in EmployeList)
            {
                Console.WriteLine("Clave: {0}, Valor: {1}", employee.Key, employee.Value);
            }

            //ordenar los elementos del diccionario.

            var dic = EmployeList.Keys.ToList();
            dic.Sort();

            Console.WriteLine("\n");

            Console.WriteLine("DICCIONARIO ORDENADO");

            Console.WriteLine("\n");
            foreach (var item in dic)
            {
                Console.WriteLine($"{item}: {EmployeList[item]}");
            }

            Console.WriteLine("\n");
            //contar los elementos del diccionario.
            Console.WriteLine($"ELEMENTOS DE EL DICCIONARIO: {EmployeList.Count}");

            Console.WriteLine();

            //ejercicio 3 de la clase de programacion.
            Dictionary<string, int> BryanMartinez = new Dictionary<string, int>();
            BryanMartinez.Add("Bryan Martinez", 19);
            BryanMartinez.Add("Ada Guevara", 21);
            BryanMartinez.Add("Renes Martinez", 20);
            BryanMartinez.Add("Melisa Morales", 25);

            //leer el diccionario y mostrar los datos 
            foreach (KeyValuePair<string, int> bra in BryanMartinez)
            {
                Console.WriteLine("Clave: {0}, Valor: {1}", bra.Key, bra.Value);
            }

            Console.WriteLine("\n");

            //ordenar los elementos del diccionario
            var familiaBryanMartinez = BryanMartinez.Keys.ToList();
            familiaBryanMartinez.Sort();

            Console.WriteLine("DICCIONARIO DE MANERA ORDENADA");
            Console.WriteLine("\n");
            foreach (var sec in familiaBryanMartinez)
            {
                Console.WriteLine("{0}: {1}", sec, BryanMartinez[sec]);
            }

            Console.WriteLine("\n");

            //contar los elementos del diccionario
            Console.WriteLine("ELEMENTOS DE EL DICCIONARIO: {0}", BryanMartinez.Count);
            Console.ReadKey();

            Console.WriteLine("\n");

            Console.WriteLine("By: Bryan Martinez...");
        }
    }
}