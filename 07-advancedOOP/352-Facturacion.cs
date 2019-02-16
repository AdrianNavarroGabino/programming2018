// Adrián Navarro Gabino

using System;

class Cliente
{
    protected int codigo;
    protected string dniOCif;
    protected string nombre;

    public Cliente(int codigo, string dniOCif, string nombre)
    {
        this.codigo = codigo;
        this.dniOCif = dniOCif;
        this.nombre = nombre;
    }

    public int GetCodigo() { return codigo; }
    public string GetDniOCif() { return dniOCif; }
    public string GetNombre() { return nombre; }

    public void SetNombre(string nombre) { this.nombre = nombre; }
}

class Articulo
{
    protected int codigo;
    protected string descripcion;
    protected double pvp;

    public Articulo(int codigo, string descripcion, double pvp)
    {
        this.codigo = codigo;
        this.descripcion = descripcion;
        this.pvp = pvp;
    }

    public int GetCodigo() { return codigo; }
    public string GetDescripcion() { return descripcion; }
    public double GetPvp() { return pvp; }

    public void SetDescripcion(string descripcion)
    {
        this.descripcion = descripcion;
    }
    public void SetPvp(double pvp) { this.pvp = pvp; }
}

abstract class DocCliente
{
    protected int numero;
    protected DateTime fecha;
    protected Cliente cliente;

    public DocCliente(int numero, DateTime fecha, Cliente cliente)
    {
        // TO DO
    }

    public DocCliente(DateTime fecha, Cliente cliente)
    {
        // TO DO
    }

    public DocCliente(Cliente cliente) : this(DateTime.Now, cliente)
    {
        // TO DO
    }
}

abstract class LinDocCliente
{
    protected Articulo articulo;
    protected int cantidad;
    protected int codigoArticulo;
    protected string descripcionArticulo;

    public LinDocCliente(Articulo articulo, int cantidad)
    {
        this.articulo = articulo;
        this.cantidad = cantidad;
        codigoArticulo = articulo.GetCodigo();
        descripcionArticulo = articulo.GetDescripcion();
    }
}

class LinFact : LinDocCliente
{
    protected double pvpArticulo;

    public LinFact(Articulo articulo, int cantidad) :
            base(articulo, cantidad)
    {
        pvpArticulo = articulo.GetPvp();
    }
}

class Factura : DocCliente
{
    public Factura(int numero, DateTime fecha, Cliente cliente) :
        base(numero, fecha, cliente)
    {
        // TO DO
    }

    public Factura(DateTime fecha, Cliente cliente) : base(fecha, cliente)
    {
        // TO DO
    }

    public Factura(Cliente cliente) : base(DateTime.Now, cliente)
    {
        // TO DO
    }
    
    public void Add(LinFact linea)
    {
        // TO DO
    }
}

class LinAlb : LinDocCliente
{
    public LinAlb(Articulo articulo, int cantidad) :
            base(articulo, cantidad)
    {
    }
}

class Albaran : DocCliente
{
    public Albaran(int numero, DateTime fecha, Cliente cliente) :
        base(numero, fecha, cliente)
    {
        // TO DO
    }

    public Albaran(DateTime fecha, Cliente cliente) : base(fecha, cliente)
    {
        // TO DO
    }

    public Albaran(Cliente cliente) : base(DateTime.Now, cliente)
    {
        // TO DO
    }
    
    public void Add(LinAlb linea)
    {
        // TO DO
    }
}

class Facturacion
{
    static void Main()
    {
        Cliente cliente = new Cliente(1, "111C", "Antonio");
        Articulo guitarra = new Articulo(
                                    1, "Fender Stratocaster", 599.95);
        Albaran albaran = new Albaran(cliente);

        albaran.Add(new LinAlb(guitarra, 1));
    }
}
