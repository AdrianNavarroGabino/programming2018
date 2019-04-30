// Adrián Navarro Gabino

using System;

class Date
{
    static void Main()
    {
        DateTime now = DateTime.Now;
        
        string[] diaSemana = {"domingo","lunes","martes","miércoles","jueves",
            "viernes","sábado"};
        
        string[] mes = {"enero", "febrero", "marzo",
                        "abril", "mayo", "junio",
                        "julio", "agosto", "septiembre",
                        "octubre", "noviembre", "diciembre"};
        
        Console.WriteLine("Hoy es " + diaSemana[(int)now.DayOfWeek] + ", " +
            now.Day + " de " + mes[now.Month - 1] + " de " + now.Year +
            ". Son las " + now.Hour.ToString("00") + ":" +
            now.Minute.ToString("00"));
    }
}
