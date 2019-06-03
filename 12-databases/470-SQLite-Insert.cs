// Adrián Navarro Gabino

using System;
using System.Data.SQLite;

namespace EjemploSQLite
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Creando la base de datos...");

            SQLiteConnection conexion =
              new SQLiteConnection
              ("Data Source=series.sqlite;Version=3;New=True;Compress=True;");
            conexion.Open();

            string creacion = "create table series "+
                "("+
                "    id int primary key,"+
                "    titulo varchar(50),"+
                "    genero varchar(25),"+
                "    anyo int"+
                "); ";
            SQLiteCommand cmd = new SQLiteCommand(creacion, conexion);
            cmd.ExecuteNonQuery();

            string insercion = "insert into series values "+
                "(1, 'Rebelde', 'Telenovela', 2004);";
            cmd = new SQLiteCommand(insercion, conexion);
            int cantidad = cmd.ExecuteNonQuery();
            if (cantidad < 1)
                Console.WriteLine("No guardado");

            insercion = "insert into series  " +
                "(id, titulo, anyo) values "+
                "(2, 'Las tres mellizas', 1997);";
            cmd = new SQLiteCommand(insercion, conexion);
            cantidad = cmd.ExecuteNonQuery();
            if (cantidad < 1)
                Console.WriteLine("No guardado");

            conexion.Close();

            Console.WriteLine("Creada.");

        }
    }
}
