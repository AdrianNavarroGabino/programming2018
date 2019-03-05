// Adrián Navarro Gabino

using System;
using System.Collections.Generic;

class Ejercicio2
{
    static string ElegirOpcion()
    {
        Console.WriteLine("Elige una opción:");
        Console.WriteLine("1. Añadir nuevo dato");
        Console.WriteLine("2. Ver datos existentes");
        Console.WriteLine("3. Ver cima de la cola");
        Console.WriteLine("0. Salir");
        Console.WriteLine();

        return Console.ReadLine();
    }

    static void AnyadirDato(Queue<float> miCola)
    {
        float numero = 0f;
        bool numeroCorrecto = false;
        while(!numeroCorrecto)
        {
            try
            {
                Console.Write("Dato a introducir: ");
                numero = Convert.ToSingle(Console.ReadLine());
                numeroCorrecto = true;
            }
            catch(Exception)
            {
                Console.WriteLine("Número incorrecto");
            }
        }
        
        miCola.Enqueue(numero);
        Console.WriteLine("Número añadido");
    }

    static void VerDatos(Queue<float> miCola)
    {
        while(miCola.Count > 0)
        {
            Console.Write(miCola.Dequeue() + " ");
        }
        Console.WriteLine();
    }

    static void Main()
    {
        Queue<float> miCola = new Queue<float>();
        string opcion;

        do
        {
            opcion = ElegirOpcion();

            switch(opcion)
            {
                case "1": AnyadirDato(miCola); break;
                case "2": VerDatos(miCola); break;
                case "3": Console.WriteLine("Cima: " + miCola.Peek()); break;
                case "0": break;
                default: Console.WriteLine("Opción incorrecta"); break;
            }
            Console.WriteLine();

        } while (opcion != "0");

        Console.WriteLine("Quedan " + miCola.Count + " números en la cola");
        Console.WriteLine("Hasta otra");
    }
}
