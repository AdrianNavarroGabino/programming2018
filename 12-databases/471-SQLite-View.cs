// Adrián Navarro Gabino

using System;
using System.Data.SQLite;

class Program
{
    static void Main(string[] args)
    {
        SQLiteConnection conexion =
            new SQLiteConnection
            ("Data Source=series.sqlite;Version=3;New=False;Compress=True;");
        conexion.Open();

        string consulta = "select * from series";
        SQLiteCommand cmd = new SQLiteCommand(consulta, conexion);
        SQLiteDataReader datos = cmd.ExecuteReader();
        while (datos.Read())
        {
            string titulo = Convert.ToString(datos[1]);
            int anyo = Convert.ToInt32(datos[3]);
            Console.WriteLine(titulo + " ("+anyo+")");
        }
        conexion.Close();
    }
}
