// Adrián Navarro Gabino

using System;

abstract class Persona
{
    protected string nombreCompleto;
    protected int codigo;
    
    public string NombreCompleto
    {
        get
        {
            return nombreCompleto;
        }
        set
        {
            nombreCompleto = value;
        }
    }
    
    public int Codigo
    {
        get
        {
            return codigo;
        }
        set
        {
            codigo = value;
        }
    }
    
    public Persona(string nombreCompleto, int codigo)
    {
        this.nombreCompleto = nombreCompleto;
        this.codigo = codigo;
    }
    
    public override string ToString()
    {
        return "Nombre completo: " + this.nombreCompleto + ", código: " +
            this.codigo;
    }
}

class Medico : Persona
{
    protected string especialidad;
    
    public string Especialidad
    {
        get
        {
            return especialidad;
        }
        set
        {
            especialidad = value;
        }
    }
    
    public Medico(string nombreCompleto, int codigo, string especialidad) :
        base(nombreCompleto, codigo)
    {
        this.especialidad = especialidad;
    }
    
    public Medico(string nombreCompleto, int codigo) :
        base(nombreCompleto, codigo)
    {
        this.especialidad = "Medicina general";
    }
    
    public override string ToString()
    {
        return base.ToString() + ", especialidad: " + this.especialidad;
    }
}

class Enfermero : Persona
{
    public Enfermero(string nombreCompleto, int codigo) :
        base(nombreCompleto, codigo)
    {
    }
}

class Paciente : Persona
{
    public Paciente(string nombreCompleto, int codigo) :
        base(nombreCompleto, codigo)
    {
    }
}

class Visita
{
    public Paciente Enfermo { get; set; }
    public Medico MedicoEncargado { get; set; }
    public DateTime FechaYHora { get; set; }
    public string Motivo { get; set; }
    public string Diagnostico { get; set; }
    
    public Visita(Paciente enfermo, Medico medicoEncargado,
            string motivo, string diagnostico)
    {
        Enfermo = enfermo;
        MedicoEncargado = medicoEncargado;
        FechaYHora = DateTime.Now;
        Motivo = motivo;
        Diagnostico = diagnostico;
    }
    
    public override string ToString()
    {
        return "Enfermo: " + Enfermo.NombreCompleto + "- Médico: " +
            MedicoEncargado.NombreCompleto + "- fecha: " + FechaYHora +
            "- motivo de la visita: " + Motivo + "- diagnóstico " + Diagnostico;
    }
}

class Planificada : Visita
{
    public Planificada(Paciente enfermo, Medico medicoEncargado,
            string motivo, string diagnostico) :
            base(enfermo, medicoEncargado, motivo, diagnostico)
    {
    }
    
    public override string ToString()
    {
        return "Planificada - " + base.ToString();
    }
}

class Urgencia : Visita
{
    public bool VisitaPosterior { get; set; }
    
    public Urgencia(Paciente enfermo, Medico medicoEncargado, string motivo,
    string diagnostico, bool visitaPost) :
    base(enfermo, medicoEncargado, motivo, diagnostico)
    {
        VisitaPosterior = visitaPost;
    }
    
    public override string ToString()
    {
        string datosUrgencia = "Urgencia - " + base.ToString();
        
        if(VisitaPosterior)
            datosUrgencia += " (P)";
        
        return datosUrgencia;
    }
}

class Consulta
{
    public static int Menu()
    {
        int opcion;
        
        do
        {
            Console.WriteLine("Elige una opción:");
            Console.WriteLine("1. Añadir un paciente");
            Console.WriteLine("2. Buscar paciente");
            Console.WriteLine("3. Añadir una visita");
            Console.WriteLine("4. Ver todas las visitas");
            Console.WriteLine("5. Salir");
            Console.WriteLine();
        
            opcion = Convert.ToInt32(Console.ReadLine());
            
            if(opcion < 1 || opcion > 5)
            {
                Console.WriteLine("Opción incorrecta");
                Console.WriteLine();
            }
        } while(opcion < 1 || opcion > 5);
        
        return opcion;
    }
    
    public static void AgregarPaciente(
            Paciente[] pacientes, ref int codigo)
    {
        Console.Write("Introduce el nombre completo del paciente: ");
        string nombre = Console.ReadLine();
        
        pacientes[codigo - 1] = new Paciente(nombre, codigo);
        
        codigo++;
        
        Console.WriteLine("Paciente añadido.");
        Console.WriteLine();
    }
    
    public static void BuscarPaciente(Paciente[] pacientes)
    {
        bool encontrado = false;
        
        Console.Write("Introduce el nombre del paciente a buscar: ");
        string buscar = Console.ReadLine().ToLower();
        
        foreach(Paciente p in pacientes)
        {
            if(p.NombreCompleto.ToLower().Contains(buscar))
            {
                Console.WriteLine(p);
                encontrado = true;
            }
        }
        
        if(!encontrado)
        {
            Console.WriteLine("No hay pacientes con ese nombre");
        }
        
        Console.WriteLine();
    }
    
    public static void AgregarVisita(
        Paciente[] pacientes, Medico[] medicos, Visita[] visitas,
        ref int contadorVisitas, int codigoMax)
    {
        Console.Write("¿Urgencia o planificada?");
        string tipo = Console.ReadLine().ToLower();
        int codPaciente;
        do
        {
            Console.Write("Código del paciente: ");
            codPaciente = Convert.ToInt32(Console.ReadLine());
            
            if(codPaciente >= codigoMax)
                Console.WriteLine("Código de paciente incorrecto");
        } while(codPaciente >= codigoMax);
        
        Paciente pacienteActual = pacientes[0];
        foreach(Paciente p in pacientes)
        {
            if(p.Codigo == codPaciente)
                pacienteActual = p;
        }
        
        int codMedico;
        do
        {
            Console.Write("Código del médico: ");
            codMedico = Convert.ToInt32(Console.ReadLine());
            
            if(codMedico != 1 || codMedico != 2)
                Console.WriteLine("Código de médico incorrecto");
        } while(codMedico != 1 || codMedico != 2);
        
        Medico medicoActual;
        
        if(codMedico == 1)
            medicoActual = medicos[0];
        else
            medicoActual = medicos[1];
        
        Console.Write("Motivo de la visita: ");
        string motivo = Console.ReadLine();
        
        Console.Write("Diagnóstico: ");
        string diagnostico = Console.ReadLine();
        
        Visita visita;
        if(tipo.Contains("urgencia"))
        {
            Console.Write("¿Ha planificado una visita posterior? ");
            string respuesta = Console.ReadLine().ToLower();
            
            bool visitaPost = respuesta.Contains("s");
            
            visita = new Urgencia(pacienteActual, medicoActual,
                motivo, diagnostico, visitaPost);
        }
        else
        {
            visita = new Planificada(pacienteActual,
                medicoActual, motivo, diagnostico);
        }
        
        visitas[contadorVisitas] = visita;
        contadorVisitas++;
    }
    
    public static void VerVisitas(Visita[] visitas)
    {
        foreach(Visita v in visitas)
        {
            Console.WriteLine(v);
        }
    }
    
    public static void Ejecutar(Paciente[] pacientes, Medico[] medicos,
        Enfermero[] enfermero, Visita[] visitas, ref int codigoPaciente,
        ref int contadorVisitas)
    {
        int opcion;
        
        do
        {
            opcion = Menu();
            
            switch(opcion)
            {
                case 1:
                    AgregarPaciente(pacientes, ref codigoPaciente);
                    break;
                case 2:
                    BuscarPaciente(pacientes);
                    break;
                case 3:
                    AgregarVisita(pacientes, medicos, visitas,
                        ref contadorVisitas, codigoPaciente);
                    break;
                case 4:
                    VerVisitas(visitas);
                    break;
                case 5:
                    Console.WriteLine("Hasta otra");
                    break;
            }
        } while(opcion != 5);
    }
    
    
    static void Main()
    {
        const int TAMANYO = 1000;
        int codigoPaciente = 1;
        int codigoMedico = 1;
        int codigoEnfermero = 1;
        int contadorVisitas = 0;
        
        Paciente[] pacientes = new Paciente[TAMANYO];
        Medico[] medicos = new Medico[TAMANYO];
        medicos[codigoMedico - 1] = new Medico(
            "Antonio López", codigoMedico);
        codigoMedico++;
        medicos[codigoMedico - 1] = new Medico(
            "Laura Martínez", 2);
        codigoMedico++;
        Enfermero[] enfermeros = new Enfermero[TAMANYO];
        enfermeros[codigoEnfermero - 1] = new Enfermero(
            "Sergio Giner", codigoEnfermero);
        codigoEnfermero++;
        Visita[] visitas = new Visita[TAMANYO];
        
        Ejecutar(pacientes, medicos, enfermeros, visitas,
            ref codigoPaciente, ref contadorVisitas);
    }
}
