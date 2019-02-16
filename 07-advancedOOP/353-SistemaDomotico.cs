// Adrián Navarro Gabino

using System;

interface ISubibleYBajable
{
    void Subir();
    void Bajar();
    void Subir(byte porcentaje);
    void Bajar(byte porcentaje);
}

interface IEncendible
{
    void Encender();
    void Apagar();
}

class Dispositivo
{
    protected string nombre;

    public Dispositivo(string nombre)
    {
        this.nombre = nombre;
    }

    public void SetNombre(string nombre) { this.nombre = nombre; }
    public string GetNombre() { return nombre; }

    public override string ToString()
    {
        return "Nombre: " + nombre;
    }
}

class Ventana : Dispositivo
{
    protected Persiana persiana;

    public Ventana(Persiana persiana) : base("Desconocido")
    {
        this.persiana = persiana;
    }

    public Persiana GetPersiana()
    {
        return persiana;
    }

    public override string ToString()
    {
        return base.ToString() + ", persiana: " + persiana.ToString();
    }
}

class Persiana : Dispositivo, ISubibleYBajable
{
    protected byte posicion;

    public Persiana(byte posicion) : base("Desconocido")
    {
        if (posicion >= 0 && posicion <= 100)
            this.posicion = posicion;
        else
        {
            this.posicion = 0;
        }
    }

    public byte GetPosicion() { return posicion; }

    public void Subir()
    {
        posicion = 100;
    }

    public void Bajar()
    {
        posicion = 0;
    }

    public void Subir(byte porcentaje)
    {
        if (posicion + porcentaje <= 100)
            posicion += porcentaje;
        else
            Console.WriteLine("No se puede subir tanto");
    }

    public void Bajar(byte porcentaje)
    {
        if (posicion - porcentaje >= 0)
            posicion -= porcentaje;
        else
            Console.WriteLine("No se puede bajar tanto");
    }

    public override string ToString()
    {
        return base.ToString() + ", posición: " + posicion;
    }
}

class Toldo : Persiana
{
    public Toldo(byte porcentaje) : base(porcentaje)
    {
    }
}

class Puerta : Dispositivo
{
    protected bool estaBloqueada;

    public Puerta(bool estaBloqueada) : base("Desconocido")
    {
        this.estaBloqueada = estaBloqueada;
    }

    public bool GetEstaBloqueada() { return estaBloqueada; }

    public void Bloquear()
    {
        estaBloqueada = true;
    }

    public void Desbloquear()
    {
        estaBloqueada = false;
    }

    public override string ToString()
    {
        return base.ToString() + ", ¿bloqueada? " + estaBloqueada;
    }
}

class PuertaDeGaraje : Puerta, ISubibleYBajable
{
    protected byte posicion;

    public PuertaDeGaraje(bool estaBloqueada, byte posicion) :
        base(estaBloqueada)
    {
        if (!estaBloqueada)
            this.posicion = posicion;
        else
            this.posicion = 0;
    }

    public byte GetPosicion() { return posicion; }

    public void Subir()
    {
        posicion = 100;
    }

    public void Bajar()
    {
        posicion = 0;
    }

    public void Subir(byte porcentaje)
    {
        if (posicion + porcentaje <= 100)
            posicion += porcentaje;
        else
            Console.WriteLine("No se puede subir tanto");
    }

    public void Bajar(byte porcentaje)
    {
        if (posicion - porcentaje >= 0)
            posicion -= porcentaje;
        else
            Console.WriteLine("No se puede bajar tanto");
    }

    public override string ToString()
    {
        return base.ToString() + ", posicion: " + posicion;
    }
}

abstract class ObjetoQueCalienta : Dispositivo
{
    protected int grados;
    protected bool estaEncendido;

    public ObjetoQueCalienta(bool estaEncendido, int grados) :
        base("Desconocido")
    {
        this.grados = grados;
        this.estaEncendido = estaEncendido;
    }

    public ObjetoQueCalienta(int grados) : this(false, grados)
    {
    }

    public int GetTemperatura() { return grados; }
    public bool GetEstaEncendido() { return estaEncendido; }

    public void Encender()
    {
        estaEncendido = true;
    }

    public void Apagar()
    {
        estaEncendido = false;
    }

    public override string ToString()
    {
        return base.ToString() + ", grados: " + grados + ", ¿encendido? " +
            estaEncendido;
    }
}

class Calefaccion : ObjetoQueCalienta, IEncendible
{
    public Calefaccion(bool estaEncendido, int grados) :
        base(estaEncendido, grados)
    {
    }

    public Calefaccion(int grados) : base(false, grados)
    {
    }
}

class Horno : ObjetoQueCalienta, IEncendible
{
    public Horno(bool estaEncendido, int grados) :
        base(estaEncendido, grados)
    {
    }

    public Horno(int grados) : base(false, grados)
    {
    }
}

class Luz : Dispositivo, IEncendible
{
    protected bool estaEncendida;

    public Luz(bool estaEncendida) : base("Desconocido")
    {
        this.estaEncendida = estaEncendida;
    }

    public bool GetEstaEncendida() { return estaEncendida; }

    public void Encender()
    {
        estaEncendida = true;
    }

    public void Apagar()
    {
        estaEncendida = false;
    }

    public override string ToString()
    {
        return base.ToString() + ", ¿encendida? " + estaEncendida;
    }
}

class RobotAspirador : Dispositivo, IEncendible
{
    protected bool estaEncendido;

    public RobotAspirador(bool estaEncendido) : base("Desconocido")
    {
        this.estaEncendido = estaEncendido;
    }

    public bool GetEstaEncendido() { return estaEncendido; }

    public void Encender()
    {
        estaEncendido = true;
    }

    public void Apagar()
    {
        estaEncendido = false;
    }

    public override string ToString()
    {
        return base.ToString() + ", ¿encendida? " + estaEncendido;
    }
}

class SistemaDomotico
{
    static void Main()
    {
        const int TAMANYO = 100;
        Dispositivo[] d = new Dispositivo[TAMANYO];

        d[0] = new Ventana(new Persiana(10));
        d[1] = new Ventana(new Persiana(25));
        d[2] = new Ventana(new Persiana(45));
        d[3] = new Puerta(true);
        d[4] = new PuertaDeGaraje(false, 10);
        d[5] = new Toldo(70);
        d[6] = new Luz(false);
        d[7] = new Calefaccion(25);
        d[8] = new Calefaccion(23);

        int contador = 9;

        int opcion;
        do
        {
            Console.WriteLine("Elige una opción:");
            Console.WriteLine("1. Bloquear puerta de acceso");
            Console.WriteLine("2. Desbloquear puerta de acceso");
            Console.WriteLine("3. Encender punto de luz");
            Console.WriteLine("4. Apagar punto de luz");
            Console.WriteLine("5. Subir por completo puerta del garaje");
            Console.WriteLine("6. Bajar por completo puerta del garaje");
            Console.WriteLine("7. Subir 25% las 3 persianas");
            Console.WriteLine("8. Recoger el toldo");
            Console.WriteLine("9. Extender el toldo");
            Console.WriteLine("10. Subir un grado cada calefacción");
            Console.WriteLine("11. Bajar un grado cada calefacción");
            Console.WriteLine("12. Ver estado de los dispositivos");
            Console.WriteLine("0. Salir");

            opcion = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            switch (opcion)
            {
                case 1: ((Puerta) (d[3])).Bloquear(); break;
                case 2: ((Puerta)(d[3])).Desbloquear(); break;
                case 3: ((Luz)(d[6])).Encender(); break;
                case 4: ((Luz)(d[6])).Apagar(); break;
                case 5: ((PuertaDeGaraje)(d[4])).Subir(); break;
                case 6: ((PuertaDeGaraje)(d[4])).Bajar(); break;
                case 7:
                    ((Ventana) (d[0])).GetPersiana().Subir(25);
                    ((Ventana) (d[1])).GetPersiana().Subir(25);
                    ((Ventana) (d[2])).GetPersiana().Subir(25);
                    break;
                case 8: ((Toldo)(d[5])).Subir(); break;
                case 9: ((Toldo)(d[5])).Bajar(); break;
                case 10:
                    d[7] = new Calefaccion(
                        ((Calefaccion)(d[7])).GetTemperatura() + 1);
                    d[8] = new Calefaccion(
                        ((Calefaccion)(d[8])).GetTemperatura() + 1);
                    break;
                case 11:
                    d[7] = new Calefaccion(
                        ((Calefaccion)(d[7])).GetTemperatura() -1);
                    d[8] = new Calefaccion(
                        ((Calefaccion)(d[8])).GetTemperatura() - 1);
                    break;
                case 12:
                    for(int i = 0; i < contador; i++)
                    {
                        Console.WriteLine(d[i]);
                    }
                    Console.WriteLine();
                    break;
                case 0: Console.WriteLine("Hasta otra"); break;
                default: Console.WriteLine("Opción incorrecta"); break;
            }
        } while (opcion != 0);
    }
}
