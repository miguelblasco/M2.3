using System;

namespace Fase2 // Vídeo n°36 -> array
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arrayCities; //declaración array
            arrayCities = new string[6]; //iniciación array y número elementos que tendrá

            //rellenar array -> string[] arrayCities = {Barcelona, Madrid,.....}

            arrayCities[0] = "Barcelona";
            arrayCities[1] = "Madrid";
            arrayCities[2] = "Valencia";
            arrayCities[3] = "Málaga";
            arrayCities[4] = "Cádiz";
            arrayCities[5] = "Santander";

            Console.WriteLine("Las ciudades son: \n");

            for (int i = 0; i <= 5; i++)
            {
                Console.WriteLine($"{i+1}.-{arrayCities[i]}");
            }

            //Ordenar Array Ascendentemente
            Array.Sort(arrayCities);

            //Imprimir
            Console.WriteLine("\n\n");
            Console.WriteLine("Array ordenado:\n");
            for (int i = 0; i <= 5; i++)
            {
                Console.WriteLine($"{i+1}.-{arrayCities[i]}");
            }
            Console.ReadKey();
        }
    }
}

