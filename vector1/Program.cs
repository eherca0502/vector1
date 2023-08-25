using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vector1
{
     class SueldoOperarios
    {
        private int[] sueldos; // declaracion del vector

        public void Cargar()
        {
            string linea;
            sueldos = new int[5]; // creacion del vector
            for(int f = 0; f < 5;f++)
            {
                Console.Write("Ingrese el sueldo:");
                linea = Console.ReadLine();
                sueldos[f] = int.Parse(linea);

            }
        }
        public void Imprimir()
        {
            Console.WriteLine("Listado de todos los sueldos");
            for (int f=0; f < 5;f++)
            {
                Console.WriteLine(sueldos[f]);
            }
        }
        static void Main(string[] args)
        {
            SueldoOperarios sueldooperarios = new SueldoOperarios();
            sueldooperarios.Cargar();
            sueldooperarios.Imprimir();
            Console.ReadKey();
        }
    }
}
