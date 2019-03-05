// Adrián Navarro Gabino

using System;
using System.Collections.Generic;

class Programa : IComparable<Programa>
{
    public string Nombre { get; set; }
    public string SistemaOperativo { get; set; }
    public CopiaSeguridad Copia { get; set; }

    public Programa(string nombre, string so, CopiaSeguridad copia)
    {
        Nombre = nombre;
        SistemaOperativo = so;
        Copia = copia;
    }

    public override string ToString()
    {
        return "Nombre: " + Nombre + ", sistema operativo: " +
            SistemaOperativo + ", datos de la copia de seguridad: " +
            Copia.ToString();
    }

    public int CompareTo(Programa p2)
    {
        return String.Compare(this.Nombre, p2.Nombre, true);
    }
}

class CopiaSeguridad
{
    public double MB { get; set; }
    public string Ubicacion { get; set; }

    public CopiaSeguridad(double mb, string ubicacion)
    {
        MB = mb;
        Ubicacion = ubicacion;
    }

    public override string ToString()
    {
        return "tamaño: " + MB + "MB, ubicacion: " + Ubicacion;
    }
}


class ColeccionDeSoftware
{
    static string ElegirOpcion()
    {
        Console.WriteLine("Elige una opción");
        Console.WriteLine("1. Añadir un nuevo programa");
        Console.WriteLine("2. Buscar programa");
        Console.WriteLine("3. Modificar programa");
        Console.WriteLine("4. Eliminar programa");
        Console.WriteLine("5. Insertar programa en una cierta posición");
        Console.WriteLine("6. Ordenar alfabeticamente por nombre");
        Console.WriteLine("7. Salir");
        Console.WriteLine();

        return Console.ReadLine();
    }

    static void Anyadir(List<Programa> lista, int posicion)
    {
        string nombre;
        do
        {
            Console.Write("Introduce el nombre del programa: ");
            nombre = Console.ReadLine();

            if(nombre == "")
                Console.WriteLine("El nombre no puede estar vacío");
        } while (nombre == "");

        string so;
        do
        {
            Console.Write("Introduce el S.O. del programa: ");
            so = Console.ReadLine();

            if(so == "")
                Console.WriteLine("El sistema operativo no puede estar vacío");
        } while (so == "");

        double mb = 0;
        bool mbCorrectos = false;
        while (!mbCorrectos)
        {
            try
            {
                Console.Write("Introduce el tamaño de la copia de seguridad: ");
                mb = Convert.ToDouble(Console.ReadLine());
                if(mb > 0)
                    mbCorrectos = true;
                else
                    Console.WriteLine("Tamaño incorrecto");
            }
            catch (Exception)
            {
                Console.WriteLine("Tamaño incorrecto");
            }
        }

        string ubicacion;
        do
        {
            Console.Write("Introduce la ubicación de la copia de seguridad: ");
            ubicacion = Console.ReadLine();

            if(ubicacion == "")
                Console.WriteLine("La ubicación no puede estar vacía");
        } while (ubicacion == "");

        // Utilizo Insert en lugar de Add para poder reutilizar el codigo en
        // el metodo Modificar e Insertar
        lista.Insert(posicion,
            new Programa(nombre, so, new CopiaSeguridad(mb, ubicacion)));
    }

    static void Buscar(List<Programa> lista)
    {
        Console.Write("¿Qué programa quieres buscar? ");
        string buscar = Console.ReadLine();

        bool encontrado = false;

        foreach(Programa p in lista)
        {
            if(p.ToString().ToLower().Contains(buscar))
            {
                Console.WriteLine(p);
                encontrado = true;
            }
        }

        if(!encontrado)
            Console.WriteLine("Programa no encontrado");
    }

    static void Modificar(List<Programa> lista)
    {
        Console.Write("¿Qué posición quieres modificar? ");
        int posicion = Convert.ToInt32(Console.ReadLine()) - 1;

        lista.RemoveAt(posicion);
        Anyadir(lista, posicion);
    }

    static void Eliminar(List<Programa> lista)
    {
        Console.Write("¿Qué posición quieres eliminar? ");
        int posicion = Convert.ToInt32(Console.ReadLine()) - 1;

        lista.RemoveAt(posicion);
    }

    static void Insertar(List<Programa> lista)
    {
        Console.Write("¿En qué posición quieres insertar un programa? ");
        int posicion = Convert.ToInt32(Console.ReadLine()) - 1;
        
        Anyadir(lista, posicion);
    }


    static void Main(string[] args)
    {
        List<Programa> lista = new List<Programa>();

        string opcion;

        do
        {
            opcion = ElegirOpcion();
            Console.WriteLine();

            switch(opcion)
            {
                case "1": Anyadir(lista,lista.Count); break;
                case "2": Buscar(lista); break;
                case "3": Modificar(lista); break;
                case "4": Eliminar(lista); break;
                case "5": Insertar(lista); break;
                case "6": lista.Sort(); break;
                case "7": Console.WriteLine("Hasta otra"); break;
                default: Console.WriteLine("Opción incorrecta"); break;
            }
            Console.WriteLine();
        } while (opcion != "7");
    }
}
