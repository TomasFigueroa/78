using System;
using System.Collections.Generic;


class Program
{
    static void Main()
    {
        // Crear un diccionario inglés-español
        Dictionary<string, string> diccionario = new Dictionary<string, string>();
        diccionario.Add("hello", "hola");
        diccionario.Add("goodbye", "adiós");
        diccionario.Add("cat", "gato");
        diccionario.Add("dog", "perro");
        diccionario.Add("house", "casa");

        Console.WriteLine("Ingresa una palabra en inglés para traducirla al español:");
        string palabra = Console.ReadLine().ToLower(); // Convertir la entrada a minúsculas

        if (diccionario.ContainsKey(palabra))
        {
            string traduccion = diccionario[palabra];
            Console.WriteLine($"{palabra} en español es {traduccion}");
        }
        else
        {
            Console.WriteLine($"La palabra {palabra} no está en el diccionario.");
        }

        Console.WriteLine("Presiona cualquier tecla para salir...");
        Console.ReadKey();
    }
}
