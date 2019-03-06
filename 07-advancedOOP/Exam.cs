// Adrián Navarro Gabino

using System;

abstract class Obra
{
    protected string autor;
    protected string titulo;
    protected int anyo;

    public Obra(string autor, string titulo, int anyo)
    {
        this.autor = autor;
        this.titulo = titulo;
        this.anyo = anyo;
    }

    public void SetAutor(string autor) { this.autor = autor; }
    public void SetTitulo(string titulo) { this.titulo = titulo; }
    public void SetAnyo(int anyo) { this.anyo = anyo; }

    public string GetAutor() { return autor; }
    public string GetTitulo() { return titulo; }
    public int GetAnyo() { return anyo; }

    public override string ToString()
    {
        return autor + " - " + titulo + " - " + anyo;
    }

    public abstract void MostrarDatos();
}

class Pintura : Obra
{
    protected string tecnica;

    public Pintura(string autor, string titulo, int anyo, string tecnica) :
        base(autor, titulo, anyo)
    {
        this.tecnica = tecnica;
    }

    public void SetTecnica(string tecnica) { this.tecnica = tecnica; }

    public string GetTecnica() { return tecnica; }

    public override string ToString()
    {
        return base.ToString() + " - " + tecnica;
    }

    public override void MostrarDatos()
    {
        Console.Write(ToString() + "(Pintura)");
    }
}

class Escultura : Obra
{
    protected string material;

    public Escultura(string autor, string titulo, int anyo, string material) :
        base(autor, titulo, anyo)
    {
        this.material = material;
    }

    public void SetMaterial(string material) { this.material = material; }

    public string GetMaterial() { return material; }

    public override string ToString()
    {
        return base.ToString() + " - " + material;
    }

    public override void MostrarDatos()
    {
        Console.Write(ToString() + "(Escultura)");
    }
}

abstract class Empleado
{
    public string Nombre { get; set; }
    public string Sector { get; set; }

    public Empleado(string nombre, string sector)
    {
        Nombre = nombre;
        Sector = sector;
    }

    public override string ToString()
    {
        return Nombre + " | " + Sector;
    }
}

class EmpleadoEnPlantilla : Empleado
{
    public int Codigo { get; }
    public string Direccion { get; set; }

    public EmpleadoEnPlantilla(
        int codigo, string nombre, string sector, string direccion) :
        base(nombre, sector)
    {
        Codigo = codigo;
        Sector = sector;
    }

    public EmpleadoEnPlantilla(
        int codigo, string nombre, string sector) :
        this(codigo, nombre, sector, "")
    {
    }

    public override string ToString()
    {
        return base.ToString() + " (P)";
    }
}

class Interesado : Empleado
{
    public DateTime FechaUltimoContacto { get; set; }

    public Interesado(
        string nombre, string sector, DateTime fechaUltimoContacto) :
        base(nombre, sector)
    {
        FechaUltimoContacto = fechaUltimoContacto;
    }

    public override string ToString()
    {
        return base.ToString() + " (I)";
    }
}

class InteresadoDescartado : Interesado
{
    public string MotivoDescarte { get; set; }

    public InteresadoDescartado(
        string nombre, string sector, DateTime fechaUltimoContacto) :
        base(nombre, sector, fechaUltimoContacto)
    {
    }

    public InteresadoDescartado(
        string nombre, string sector, DateTime fechaUltimoContacto,
        string motivoDescarte) : this(nombre, sector, fechaUltimoContacto)
    {
        MotivoDescarte = motivoDescarte;
    }
}

class Museo
{
    protected Obra[] obras;
    protected Empleado[] empleados;

    public Obra[] Obras
    {
        get
        {
            return obras;
        }

        set
        {
            Obras = value;
        }

    }

    public Empleado[] Empleados
    {
        get
        {
            return empleados;
        }

        set
        {
            Empleados = value;
        }

    }

    public void Ejecutar()
    {
        const int CANT_EMPL = 1000;
        const int CANT_OBRAS = 5000;

        Empleado[] e = new Empleado[CANT_EMPL];
        Obra[] o = new Obra[CANT_OBRAS];

        e[0] = new EmpleadoEnPlantilla(1, "Manuel", "Limpieza");
        e[1] = new EmpleadoEnPlantilla(2, "Luisa", "Seguridad");

        o[0] = new Pintura(
            "Anónimo", "Pintura anónima bonita", 2000, "Brocha gorda");
        o[1] = new Escultura(
            "Clase 5 años A", "Camión con plastilina", 2017, "Plastilina");

        int contadorEmpl = 2;
        int contadorObras = 2;

        int opcion;

        do
        {
            MostrarMenu();
            opcion = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            switch (opcion)
            {
                case 1:
                    if (contadorEmpl <= CANT_EMPL)
                    {
                        e[contadorEmpl] = NuevoEmpleado(1);
                        contadorEmpl++;
                    }
                    else
                    {
                        Console.WriteLine("Base de datos de empleados llena");
                    }
                    break;
                case 2:
                    if (contadorEmpl <= CANT_EMPL)
                    {
                        e[contadorEmpl] = NuevoEmpleado(2);
                        contadorEmpl++;
                    }
                    else
                    {
                        Console.WriteLine("Base de datos de empleados llena");
                    }
                    break;
                case 3:
                    BuscarEmpleado(contadorEmpl, e);
                    break;
                case 4:
                    if (contadorObras <= CANT_OBRAS)
                    {
                        o[contadorObras] = NuevaObra();
                        contadorObras++;
                    }
                    else
                    {
                        Console.WriteLine("Base de datos de empleados llena");
                    }
                    break;
                case 5:
                    BuscarObra(contadorObras, o);
                    break;
                case 0:
                    Console.WriteLine("Hasta otra!");
                    break;
                default:
                    Console.WriteLine("Opción incorrecta");
                    break;
            }

            Console.WriteLine();
        } while (opcion != 0);
    }

    public void MostrarMenu()
    {
        Console.WriteLine("Elige una opción:");
        Console.WriteLine("1. Añadir empleado a la plantilla");
        Console.WriteLine("2. Añadir un interesado en trabajar en el museo");
        Console.WriteLine("3. Buscar empleado");
        Console.WriteLine("4. Añadir una obra");
        Console.WriteLine("5. Buscar una obra");
        Console.WriteLine("0. Salir");
        Console.WriteLine();
    }

    public Empleado NuevoEmpleado(int valor)
    {
        Console.Write("Introduce el nombre: ");
        string nombre = Console.ReadLine();
        Console.Write("Introduce el sector: ");
        string sector = Console.ReadLine();

        if (valor == 1)
        {
            Console.Write("Introduce el código: ");
            int codigo = Convert.ToInt32(Console.ReadLine());
            Console.Write("Introduce la dirección: ");
            string direccion = Console.ReadLine();

            return new EmpleadoEnPlantilla(codigo, nombre, sector, direccion);
        }

        Console.Write("Introduce la fecha del último contacto: ");
        DateTime fechaUltimoContacto = Convert.ToDateTime(Console.ReadLine());

        return new Interesado(nombre, sector, fechaUltimoContacto);
    }

    public Obra NuevaObra()
    {
        Console.Write("¿Pintura o escultura? ");
        string pintOEsc = Console.ReadLine().ToLower();

        Console.Write("Introduce el autor: ");
        string autor = Console.ReadLine();
        Console.Write("Introduce el título: ");
        string titulo = Console.ReadLine();
        Console.Write("Introduce el año: ");
        int anyo = Convert.ToInt32(Console.ReadLine());

        if (pintOEsc.Contains("pintura"))
        {
            Console.Write("Introduce la técnica: ");
            string tecnica = Console.ReadLine();

            return new Pintura(autor, titulo, anyo, tecnica);
        }

        Console.Write("Introduce el material: ");
        string material = Console.ReadLine();

        return new Escultura(autor, titulo, anyo, material);
    }

    public void BuscarEmpleado(int contador, Empleado[] e)
    {
        bool encontrado = false;

        Console.Write("Introduce el empleado a buscar: ");
        string buscar = Console.ReadLine().ToLower();

        for (int i = 0; i < contador; i++)
        {
            if (e[i].ToString().ToLower().Contains(buscar))
            {
                encontrado = true;
                Console.WriteLine(e[i]);
            }
        }

        if (!encontrado)
        {
            Console.WriteLine("Empleado no encontrado");
        }
    }

    public void BuscarObra(int contador, Obra[] o)
    {
        bool encontrado = false;

        Console.Write("Introduce la obra a buscar: ");
        string buscar = Console.ReadLine().ToLower();

        for (int i = 0; i < contador; i++)
        {
            if (o[i].ToString().ToLower().Contains(buscar))
            {
                encontrado = true;
                Console.WriteLine(o[i]);
            }
        }

        if (!encontrado)
        {
            Console.WriteLine("Obra no encontrada");
        }
    }

    static void Main()
    {
        Museo m = new Museo();
        m.Ejecutar();
    }
}
