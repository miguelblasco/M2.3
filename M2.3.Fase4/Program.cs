using System;


namespace ConsoleApp4 //vídeo n° 39 -> propiedad "length" de los array
                      // búsqueda en google: .net library (vídeo n°39)
                      //vídeo n°37 -> array implícito
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("1.-Nombre ciudad:\n");

            var arrayBarcelona = new[] { "B", "a", "r", "c", "e", "l", "o", "n", "a" }; //array implícito


            for (int i = 0; i < arrayBarcelona.Length; i++)
            {
                Console.WriteLine(arrayBarcelona[i]);
            }

            Console.WriteLine("\n\n");
            Console.WriteLine("1.-Nombre invertido:\n");
            Array.Reverse(arrayBarcelona);
            foreach (var ciudad in arrayBarcelona)
            {
                Console.WriteLine(ciudad);
            }

            Console.WriteLine("\n\n");
            Console.WriteLine("2.-Nombre ciudad:\n");

            var arrayMadrid = new[] { "M", "a", "d", "r", "i", "d"}; //array implícito


            for (int i = 0; i < arrayMadrid.Length; i++)
            {
                Console.WriteLine(arrayMadrid[i]);
            }

            Console.WriteLine("\n\n");
            Console.WriteLine("2.-Nombre invertido:\n");
            Array.Reverse(arrayMadrid);
            foreach (var ciudad in arrayMadrid)
            {
                Console.WriteLine(ciudad);
            }

            Console.WriteLine("\n\n");
            Console.WriteLine("3.-Nombre ciudad:\n");

            var arrayValencia = new[] { "V", "a", "l", "e", "n", "c", "i", "a"}; //array implícito


            for (int i = 0; i < arrayValencia.Length; i++)
            {
                Console.WriteLine(arrayValencia[i]);
            }

            Console.WriteLine("\n\n");
            Console.WriteLine("3.-Nombre invertido:\n");
            Array.Reverse(arrayValencia);
            foreach (var ciudad in arrayValencia)
            {
                Console.WriteLine(ciudad);
            }

            Console.WriteLine("\n\n");
            Console.WriteLine("4.-Nombre ciudad:\n");

            var arrayMalaga = new[] { "M", "á", "l", "a", "g", "a"}; //array implícito


            for (int i = 0; i < arrayMalaga.Length; i++)
            {
                Console.WriteLine(arrayMalaga[i]);
            }

            Console.WriteLine("\n\n");
            Console.WriteLine("4.-Nombre invertido:\n");
            Array.Reverse(arrayMalaga);
            foreach (var ciudad in arrayMalaga)
            {
                Console.WriteLine(ciudad);
            }

            Console.WriteLine("\n\n");
            Console.WriteLine("5.-Nombre ciudad:\n");

            var arrayCadiz = new[] { "C", "á", "d", "i", "z"}; //array implícito


            for (int i = 0; i < arrayCadiz.Length; i++)
            {
                Console.WriteLine(arrayCadiz[i]);
            }

            Console.WriteLine("\n\n");
            Console.WriteLine("5.-Nombre invertido:\n");
            Array.Reverse(arrayCadiz);
            foreach (var ciudad in arrayCadiz)
            {
                Console.WriteLine(ciudad);
            }

            Console.WriteLine("\n\n");
            Console.WriteLine("6.-Nombre ciudad:\n");

            var arraySantander = new[] { "S", "a", "n", "t", "a", "n", "d", "e", "r" }; //array implícito
           

            for (int i=0; i< arraySantander.Length; i++)
            {
               Console.WriteLine(arraySantander[i]);
            }

            Console.WriteLine("\n\n");
            Console.WriteLine("6.-Nombre invertido:\n");
            Array.Reverse(arraySantander);
            foreach (var ciudad in arraySantander)
            {
                Console.WriteLine(ciudad);
            }
            
            
               

             

        }


    }
}
