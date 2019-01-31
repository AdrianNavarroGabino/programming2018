// Adrián Navarro Gabino

using System;

class Medio
{
    protected string autor;
    protected int tamanyo;
    protected string formato;
    
    public void SetAutor(string autor) { this.autor = autor; }
    public void SetTamanyo(int tamanyo) { this.tamanyo = tamanyo; }
    public void SetFormato(string formato) { this.formato = formato; }
    
    public string GetAutor() { return autor; }
    public int GetTamanyo() { return tamanyo; }
    public string GetFormato() { return formato; }
    
    public Medio(string autor, int tamanyo, string formato)
    {
        this.autor = autor;
        this.tamanyo = tamanyo;
        this.formato = formato;
    }
    
    public override string ToString()
    {
        return "Autor: " + this.autor + ", tamaño: " + this.tamanyo +
            ", formato: " + this.formato;
    }
}

class Imagen : Medio
{
    protected int ancho;
    protected int alto;
    
    public void SetAncho(int ancho) { this.ancho = ancho; }
    public void SetAlto(int alto) { this.alto = alto; }
    
    public int GetAncho() { return ancho; }
    public int GetAlto() { return alto; }
    
    public Imagen(string autor, int tamanyo, string formato,
        int ancho, int alto) : base(autor, tamanyo, formato)
    {
        this.ancho = ancho;
        this.alto = alto;
    }
    
    public override string ToString()
    {
        return base.ToString() + ", ancho: " + this.ancho + ", alto: " +
        this.alto;
    }
}

class Sonido : Medio
{
    protected bool stereo;
    protected int kbps;
    protected int duracion;
    
    public void SetStereo(bool stereo) { this.stereo = stereo; }
    public void SetKbps(int kbps) { this.kbps = kbps; }
    public void SetDuracion(int duracion) { this.duracion = duracion; }
    
    public bool GetStereo() { return stereo; }
    public int GetKbps() { return kbps; }
    public int GetDuracion() { return duracion; }
    
    public Sonido(string autor, int tamanyo, string formato,
        bool stereo, int kbps, int duracion) :
        base(autor, tamanyo, formato)
    {
        this.stereo = stereo;
        this.kbps = kbps;
        this.duracion = duracion;
    }
    
    public override string ToString()
    {
        return base.ToString() + ", stereo: " + this.stereo +
        ", kbps: " + this.kbps + ", duracion: " + this.duracion;
    }
}

class Video : Medio
{
    protected string codec;
    protected int duracion;
    protected int ancho;
    protected int alto;
    
    public void SetAncho(int ancho) { this.ancho = ancho; }
    public void SetAlto(int alto) { this.alto = alto; }
    public void SetCodec(string codec) { this.codec = codec; }
    public void SetDuracion(int duracion) { this.duracion = duracion; }
    
    public string GetCodec() { return codec; }
    public int GetDuracion() { return duracion; }
    public int GetAncho() { return ancho; }
    public int GetAlto() { return alto; }
    
    public Video(string autor, int tamanyo, string formato,
        string codec, int duracion, int ancho, int alto) :
        base(autor, tamanyo, formato)
    {
        this.ancho = ancho;
        this.alto = alto;
        this.codec = codec;
        this.duracion = duracion;
    }
    
    public override string ToString()
    {
        return base.ToString() + ", ancho: " + this.ancho +
        ", alto: " + this.alto + ", duracion: " + this.duracion +
        ", codec: " + this.codec;
    }
}

class PruebaDeMedios
{
    static void Main()
    {
        Medio m = new Medio("Anónimo", 10000, "MPEG");
        Imagen i = new Imagen("Anónimo", 500, "JPG", 800, 600);
        Sonido s = new Sonido("Anónimo", 500, "MP3", true, 50, 300);
        Video v = new Video(
            "Anónimo", 50000, "AVI", "XXX", 700, 600, 800);
            
        const int TAMANYO = 3;
        
        Medio[] medios = new Medio[TAMANYO];
        
        medios[0] = new Imagen("Anónimo", 400, "PNG", 800, 600);
        medios[1] = new Sonido("Anónimo", 550, "MIDI", false, 60, 400);
        medios[2] = new Video(
            "Anónimo", 6000, "MKV", "XX", 700, 600, 800);
            
        for(int indice = 0; indice < TAMANYO; indice++)
        {
            Console.WriteLine(medios[indice]);
        }
    }
}


