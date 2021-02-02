using System;

namespace PracticaEjercitacion
{
    // Escribe una función contarFs que tome un string como su único argumento y devuelva 
    //un número que indica cuántos caracteres “F” en mayúsculas haya en el string.
    //Despues, escribe una función llamada contarCaracteres que se comporte como contarFs,
    //excepto que toma un segundo argumento que indica el carácter 
    //que debe ser contado (en lugar de contar solo caracteres “F” en mayúscula). 
    //Reescribe contarFs para que haga uso de esta nueva función.

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(contarCaracteres("mmmm", "m"));
            Console.ReadKey();
        }

        private static int contarCaracteres(string texto, string caracter)
        {
            

            var count = 0;

            for (int i = 0; i < texto.Length; i++)
                
            {
                if (texto[i].ToString() == caracter)
                {
                    count += 1;
                }
            }


            Console.WriteLine($"La palabra {texto}, contiene {count} veces {caracter}");
            return count;
        }

        private static int contador(string texto)
        {
            return contarCaracteres(texto, "m");
        }
    }
}
