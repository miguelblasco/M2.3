using System;


namespace ConsoleApp1 //vídeo n°7 -> writeline y readline
{
    class Program
    {
        static void Main(string[] args)
        {

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




        }
    }
}
