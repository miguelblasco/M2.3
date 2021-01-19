using System;


namespace Fase 3 
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arrayModifiedCities; //declaración array
            arrayModifiedCities = new string[6]; //iniciación array y número elementos que tendrá

            //rellenar array -> string[] arrayCities = {Barcelona, Madrid,.....}

            Console.WriteLine("1.-Introduce nombre de la primera ciudad: \n"); //instrucción para sacar por pantalla mensajes
            string ciudad1 = Console.ReadLine(); // introducir un valor
            Console.WriteLine("\n\n"); // para crear una línea en blanco

            Console.WriteLine("2.-Introduce nombre de la segunda ciudad: \n");
            string ciudad2 = Console.ReadLine();
            Console.WriteLine("\n\n");

            Console.WriteLine("3.-Introduce nombre de la tercera ciudad: \n");
            string ciudad3 = Console.ReadLine();
            Console.WriteLine("\n\n");

            Console.WriteLine("4.-Introduce nombre de la cuarta ciudad: \n");
            string ciudad4 = Console.ReadLine();
            Console.WriteLine("\n\n");

            Console.WriteLine("5.-Introduce nombre de la quinta ciudad: \n");
            string ciudad5 = Console.ReadLine();
            Console.WriteLine("\n\n");

            Console.WriteLine("6.-Introduce nombre de la sexta ciudad: \n");
            string ciudad6 = Console.ReadLine();
            Console.WriteLine("\n\n");

            //mostrar por pantalla las 6 ciudades

            Console.WriteLine("Las seis ciudades son: " + (ciudad1, ciudad2, ciudad3, ciudad4, ciudad5, ciudad6));

            ciudad1 = ciudad1.Replace("a", "4").Replace("á", "4");
            ciudad2 = ciudad2.Replace("a", "4").Replace("á", "4");
            ciudad3 = ciudad3.Replace("a", "4").Replace("á", "4");
            ciudad4 = ciudad4.Replace("a", "4").Replace("á", "4");
            ciudad5 = ciudad5.Replace("a", "4").Replace("á", "4");
            ciudad6 = ciudad6.Replace("a", "4").Replace("á", "4");



            //rellenar array -> string[] arrayCities = {Barcelona, Madrid,.....}

            arrayModifiedCities[0] = ciudad1;
            arrayModifiedCities[1] = ciudad2;
            arrayModifiedCities[2] = ciudad3;
            arrayModifiedCities[3] = ciudad4;
            arrayModifiedCities[4] = ciudad5;
            arrayModifiedCities[5] = ciudad6;

            Console.WriteLine("\n\n");
            Console.WriteLine("Las ciudades modificadas son: \n");

            for (int i = 0; i <= 5; i++)
            {
                Console.WriteLine($"{i + 1}.-{arrayModifiedCities[i]}");
            }

            //Ordenar Array Ascendentemente
            Array.Sort(arrayModifiedCities);

            //Imprimir
            Console.WriteLine("\n\n");
            Console.WriteLine("Array ordenado:\n");
            for (int i = 0; i <= 5; i++)
            {
                Console.WriteLine($"{i + 1}.-{arrayModifiedCities[i]}");
            }
        }
    }
}


