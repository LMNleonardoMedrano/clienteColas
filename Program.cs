using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clienteColas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue miFila = new Queue();
            Console.Write("INGRESE EL NUMERO DE PERSONAS EN LA FILA DEL CAJERO: ");
            int n = int.Parse(Console.ReadLine());
            int tamañoFila = n;
            int contador = 0;

            while (contador < n)
            {
                Console.Write("NOMBRE DE LA PERSONA: ");
                miFila.Enqueue(Console.ReadLine());
                contador++;
            }
            Console.WriteLine("\nEL CAJERO ATENDIO A: ");

            int numeroA = 1;

            while (tamañoFila > 0)
            {
                Console.WriteLine(numeroA + ".-" + miFila.Dequeue());
                tamañoFila--;
                numeroA++;
            }

            Console.ReadKey();
        }
    }
}
