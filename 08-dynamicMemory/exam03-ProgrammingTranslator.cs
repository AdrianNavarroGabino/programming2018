// Adrián Navarro Gabino

using System;
using System.Collections;

class Ejercicio3
{
    static string ElegirOpcion()
    {
        Console.WriteLine("Elige una opción:");
        Console.WriteLine("1. Añadir traducción de C# a PHP");
        Console.WriteLine("2. Añadir traducción de PHP a JavaScript");
        Console.WriteLine("3. Consultar traducción de C# a PHP");
        Console.WriteLine("4. Consultar traducción de C# a JavaScript");
        Console.WriteLine("0. Salir");
        Console.WriteLine();

        return Console.ReadLine();
    }

    static void Anyadir(Hashtable tabla, string o1, string o2)
    {
        Console.Write("Introduce la orden en {0}: ", o1);
        string orden1 = Console.ReadLine();
        Console.Write("Introduce la orden en {0}: ", o2);
        string orden2 = Console.ReadLine();

        tabla.Add(orden1, orden2);
    }

    static void ConsultaSimple(Hashtable cSharpAPhp)
    {
        Console.WriteLine("¿Qué orden quieres traducir de C# a PHP?");
        string orden = Console.ReadLine();

        if(cSharpAPhp.ContainsKey(orden))
            Console.WriteLine(orden + " - " + cSharpAPhp[orden]);
        else
            Console.WriteLine("Orden no encontrada");
    }

    static void ConsultaDoble(Hashtable cSharpAPhp, Hashtable phpAJS)
    {
        Console.WriteLine("¿Qué orden quieres traducir de C# a JavaScript?");
        string orden = Console.ReadLine();

        if(cSharpAPhp.ContainsKey(orden) &&
            phpAJS.ContainsKey(cSharpAPhp[orden]))
        {
            Console.WriteLine(orden + " - " + phpAJS[cSharpAPhp[orden]]);
        }
        else
            Console.WriteLine("Orden no encontrada");
    }


    static void Main(string[] args)
    {
        Hashtable cSharpAPhp = new Hashtable();
        Hashtable phpAJS = new Hashtable();

        cSharpAPhp.Add("Console.Write", "echo");
        phpAJS.Add("echo", "console.log");

        string opcion;

        do
        {
            opcion = ElegirOpcion();

            switch (opcion)
            {
                case "1": Anyadir(cSharpAPhp, "C#", "PHP"); break;
                case "2": Anyadir(phpAJS, "PHP", "JavaScript"); break;
                case "3": ConsultaSimple(cSharpAPhp); break;
                case "4": ConsultaDoble(cSharpAPhp, phpAJS); break;
                case "0": Console.WriteLine("Hasta otra"); break;
                default: Console.WriteLine("Opción incorrecta"); break;
            }
            Console.WriteLine();
        } while (opcion != "0");
    }
}
