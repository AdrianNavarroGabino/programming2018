// Adrián Navarro
// Miguel Pastor
// Manuel Lago

using System;

public class ProgramasOrdenador
{
    struct Programas
    {
        public string nombre;
        public string categoria;
        public string descripcion;
        public DatosVersion version;
    }

    struct DatosVersion
    {
        public string numeroVersion;
        public byte mesLanzamiento;
        public ushort anyoLanzamiento;
    }
    public static void Main()
    {
        string opcion;
        const int TAMANYO = 100000;
        Programas[] p = new Programas[TAMANYO];
        int countProgramas = 0;

        do
        {
            Console.WriteLine("Elige una opción:");
            Console.WriteLine("1- Añadir datos de un nuevo programa");
            Console.WriteLine("2- Mostrar los nombres de todos las programas");
            Console.WriteLine("3- Ver todos los datos de un cierto programa");
            Console.WriteLine("4- Modificar una ficha");
            Console.WriteLine("5- Borrar un cierto dato");
            Console.WriteLine("6- Ordenar los datos según su nombre");
            Console.WriteLine("7- Corregir espacios redundantes");
            Console.WriteLine("T- Terminar el uso de la aplicación");
            opcion = Console.ReadLine();

            switch (opcion)
            {
                case "1":
                    if (countProgramas < TAMANYO)
                    {
                        Console.Write("Nombre del Programa #" + countProgramas + ": ");
                        p[countProgramas].nombre = Console.ReadLine();

                        if (p[countProgramas].nombre != "")
                        {
                            do
                            {
                                Console.Write("Categoría: ");
                                p[countProgramas].categoria = Console.ReadLine();

                                if (p[countProgramas].categoria.Length > 30)
                                    Console.WriteLine("Categoria debe ocupar menos de 30 letras");

                            }
                            while (p[countProgramas].categoria.Length > 30);

                            Console.Write("Descripción: ");
                            p[countProgramas].descripcion = Console.ReadLine();

                            if (p[countProgramas].descripcion.Length < 100)
                            {
                                Console.Write("Número de Versión: ");
                                p[countProgramas].version.numeroVersion = Console.ReadLine();

                                Console.Write("Mes de Lanzamiento: ");
                                p[countProgramas].version.mesLanzamiento = Convert.ToByte(Console.ReadLine());

                                Console.Write("Año de Lanzamiento: ");
                                p[countProgramas].version.anyoLanzamiento = Convert.ToUInt16(Console.ReadLine());
                            }

                            countProgramas++;
                        }
                    }
                    else
                    {
                        Console.WriteLine("No se pueden añadir mas programas");
                    }
                    break;
                case "2":
                    if (countPrograma == 0)
                    {
                        Console.WriteLine("No hay datos");
                    }
                    else
                    {
                        for (int i = 0; i < countPrograma; i++)
                        {
                            for (int j = 0; j < 20; j++)
                            {
                                Console.WriteLine("Programa {0}: ", j + 1);
                                Console.WriteLine("Nombre: " + p[j].nombre +
                                    "Categoria: " + p[j].categoria +
                                    "descripción: " + p[j].descripcion +
                                    "Version: " + p[j].version.numeroVersion +
                                    "." + p[j].version.mesLanzamiento +
                                    "." + p[j].version.anyoLanzamiento);
                            }
                            string paso = Console.ReadLine();
                        }
                    }
                    break;
                case "3":
                    Console.WriteLine("¿Qué programa quieres buscar?");
                    string buscar = Console.ReadLine();
                    bool encontrado = false;

                    if (buscar == "")
                    {
                        Console.WriteLine("Categoría: Sin datos");
                    }
                    else
                    {
                        for (int i = 0; i < countProgramas; i++)
                        {
                            if (p[i].nombre.contains(buscar) ||
                               p[i].categoria.contains(buscar) ||
                               p[i].descripcion.contains(buscar))
                            {
                                encontrado = true;

                                Console.WriteLine("Nombre: " + p[i].nombre);
                                Console.WriteLine("Categoría: " +
                                    p[i].categoria);
                                Console.WriteLine("Descripción: " +
                                    p[i].descripcion);
                                Console.WriteLine("Número de versión: " +
                                    p[i].version.numeroVersion);
                                Console.WriteLine("Mes de lanzamiento: " +
                                    p[i].version.mesLanzamiento);
                                Console.WriteLine("Año de lanzamiento: "p[i].version.anyoLanzamiento);
                                Console.WriteLine();
                            }
                        }
                        if (!encontrado)
                        {
                            Console.WriteLine("Programa no encontrado");
                        }

                        break;
                case "4":
                    Console.Write("Introduzca el número de ficha a modificar: ");
                    string numFicha = Convert.ToInt32(Console.ReadLine());
                    
                    for ( int i = 0 ; i < countPrograma ; i++ )
                    {
                        if ( p[i] == numFicha )
                        {
                            Console.WriteLine("Programa {0}: ", i + 1);
                            Console.WriteLine("Nombre: " + p[i].nombre +
                                "Categoria: " + p[i].categoria +
                                "descripción: " + p[i].descripcion +
                                "Version: " + p[i].version.numeroVersion +
                                "." + p[i].version.mesLanzamiento +
                                "." + p[i].version.anyoLanzamiento);
                        }
                    }
                    
                    Console.WriteLine("¿Que desea modificar?: ");
                    Console.WriteLine("1- Nombre");
                    Console.WriteLine("2- Categoria");
                    Console.WriteLine("3- Descripción");
                    Console.WriteLine("4- Número Versión");
                    Console.WriteLine("5- Mes versión");
                    Console.WriteLine("6- Año versión");
                    
                    opcion = Console.ReadLine();
                    
                    switch(opcion)
                    {
                        case "1":
                            Console.Write("Introduzca el nuevo nombre: ");
                            string nuevoNombre = Console.ReadLine();
                            
                            if ( nuevoNombre == "" )
                            {
                                Console.WriteLine("Ningún cambio realizado");
                            }
                            else
                            {
                                p[numFicha].nombre = nuevoNombre;
                            }
                            break;
                        case "2":
                            Console.Write("Introduzca la nueva categoria: ");
                            string nuevoCategoria = Console.ReadLine();
                            
                            if ( nuevoCategoria == "" )
                            {
                                Console.WriteLine("Ningún cambio realizado");
                            }
                            else
                            {
                                p[numFicha].categoria = nuevoCategoria;
                            }
                            break;
                        case "3":
                            Console.Write("Introduzca la nueva descripción: ");
                            string nuevaDescripcion = Console.ReadLine();
                            
                            if ( nuevoDescripcion == "" )
                            {
                                Console.WriteLine("Ningún cambio realizado");
                            }
                            else
                            {
                                p[numFicha].descripcion = nuevoDescripcion;
                            }
                            break;
                    }
                    
                    break;
                case "5":
                    Console.Write("Introduce el numero de programa que " +
                        "quieres borras: ");
                    int borrar = Convert.ToInt32(Console.ReadLine()) - 1;

                    if (borrar > countProgramas || borrar < 1)
                    {
                        Console.WriteLine("Posición incorrecta");
                    }
                    else
                    {
                        for (int i = borrar; i < countProgramas; i++)
                        {
                            p[i] = p[i + 1];
                        }
                        countProgramas--;
                    }

                    break;
                case "6":
                    Programas aux;

                    for (int i = 0; i < countProgramas - 1; i++)
                    {
                        for (int j = i + 1; j < countProgramas; j++)
                        {
                            if (p[i].nombre.CompareTo(p[j].nombre) > 0)
                            {
                                aux = p[i];
                                p[i] = p[j];
                                p[j] = aux;
                            }
                        }
                    }

                    break;
                case "7":
                    for (int i = 0; i < countProgramas; i++)
                    {
                        while (p[i].nombre.Contains("  ")
                        {
                            p[i].nombre.Replace("  ", " ");
                        }
                    }

                    break;
            }
        } while (opcion != "T");
    }
}

