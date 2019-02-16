// Adrián Navarro Gabino

using System;

class Ordenador
{
    protected Procesador procesador;
    protected Memoria memoria;
    protected string nombre;
    
    public Ordenador(
            Procesador procesador, Memoria memoria, string nombre)
    {
        this.procesador = procesador;
        this.memoria = memoria;
        this.nombre = nombre;
    }
    
    public string GetNombre() { return this.nombre; }
    
    public override string ToString()
    {
        return this.nombre + ", procesador " + procesador.ToString() +
        ", " + memoria.GetTamanyo() + " bytes de memoria";
    }
}

abstract class Procesador
{
    protected int bits;
    protected double velocidadProceso;
    protected string nombreRegistros;
    
    public Procesador(
            int bits, double velocidadProceso, string nombreRegistros)
    {
        this.bits = bits;
        this.velocidadProceso = velocidadProceso;
        this.nombreRegistros = nombreRegistros;
    }
    
    public int GetBits() { return bits; }
    public double GetVelocidadProceso() { return velocidadProceso; }
    
    public override string ToString()
    {
        return this.bits + " bits, " + this.velocidadProceso + " MHZ";
    }
    
    public void AnadirOrden(int codigo, string ensamblador)
    {
        // TO DO
    }
    
    public virtual void MostrarOrdenes()
    {
        Console.WriteLine("Lista de órdenes aún no disponible");
    }
}

class Memoria
{
    protected long tamanyo;
    protected byte[] bytes;
    
    public Memoria(long tamanyo)
    {
        this.tamanyo = tamanyo;
        this.bytes = new byte[tamanyo];
    }
    
    public Memoria(long tamanyo, int busDeDatos) : this(tamanyo)
    {
        // TO DO
    }
    
    public long GetTamanyo() { return this.tamanyo; }
    public byte GetValorMemoria(long direccion)
    {
        return bytes[direccion - 1];
    }
    public void SetValorMemoria(long direccion, byte valor)
    {
        bytes[direccion - 1] = valor;
    }
}

class ProcesadorZ80 : Procesador
{
    public ProcesadorZ80(double velocidadProceso) :
        base(8, velocidadProceso, "A B C D E F H L")
    {
    }
    
    public override void MostrarOrdenes()
    {
        Console.Write("Z80: ");
        base.MostrarOrdenes();
    }
    
    public override string ToString()
    {
        return "Z80, " + base.ToString();
    }
}

class Procesador6502 : Procesador
{
    public Procesador6502(double velocidadProceso) :
        base(8, velocidadProceso, "A X Y")
    {
    }
    
    public override void MostrarOrdenes()
    {
        Console.Write("6502: ");
        base.MostrarOrdenes();
    }
    
    public override string ToString()
    {
        return "6502, " + base.ToString();
    }
}

class Emuladores
{
    static void Main()
    {
        const int CANT_ORDENADORES = 1000;
        
        Ordenador[] o = new Ordenador[CANT_ORDENADORES];
        
        o[0] = new Ordenador(
            new ProcesadorZ80(3.5), new Memoria(16384), "ZxSpectrum");
        o[1] = new Ordenador(
            new Procesador6502(1.1), new Memoria(5120),
            "Commodore VIC-20");
        
        int contador = 2;
        
        int opcion;
        do
        {
            Console.WriteLine("Elige una opción:");
            Console.WriteLine("1. Añadir un equipo basado en el Z80");
            Console.WriteLine("2. Añadir un equipo basado en el 6502");
            Console.WriteLine("3. Ver ordenadores");
            Console.WriteLine("0. Salir");

            opcion = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            string nombre;
            double velocidad;
            long memoria;
           
            if(contador < CANT_ORDENADORES &&
                    (opcion == 1 || opcion == 2))
            {
                Console.Write("Introduce el nombre: ");
                nombre = Console.ReadLine();
                Console.Write("Introduce la velocidad en MHz: ");
                velocidad = Convert.ToDouble(Console.ReadLine());
                Console.Write("Introduce el tamaño de la memoria: ");
                memoria = Convert.ToInt64(Console.ReadLine());

                if(opcion == 1)
                    o[contador] = new Ordenador(
                        new ProcesadorZ80(velocidad),
                        new Memoria(memoria), nombre);
                else if(opcion == 2)
                    o[contador] = new Ordenador(
                        new Procesador6502(velocidad),
                        new Memoria(memoria), nombre);
                contador++;
                
                Console.WriteLine();
            }
            else if(contador >= CANT_ORDENADORES)
            {
                Console.WriteLine("Base de datos llena");
                Console.WriteLine();
            }
            else if(opcion == 3)
            {
                for(int i = 0; i < contador; i++)
                {
                    Console.WriteLine(o[i]);
                }
                
                Console.WriteLine();
            }
            else if(opcion == 0)
            {
                Console.WriteLine("Hasta otra");
            }
            else
            {
                Console.WriteLine("Opción incorrecta");
                Console.WriteLine();
            }
        }while(opcion != 0); 
    }
}
