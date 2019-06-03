// Adrián Navarro Gabino

using System;
using System.Data.SQLite;

class MainClass
{
    public static void Main(string[] args)
    {
        SQLiteConnection conexion =
              new SQLiteConnection
              ("Data Source=series.sqlite;Version=3;New=False;Compress=True;");
        conexion.Open();
        SQLiteCommand cmd;
        string opcion;
        bool continuar = true;
        while(continuar)
        {
            Console.WriteLine("1. Agregar");
            Console.WriteLine("2. Ver todo");
            Console.WriteLine("3. Salir");
            opcion = Console.ReadLine();
            switch(opcion)
            {
                case "1":
                    Console.WriteLine("Titulo?");
                    string nombre = Console.ReadLine();
                    Console.WriteLine("Año?");
                    int anyo = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Genero?");
                    string genero = Console.ReadLine();
                    Console.WriteLine("ID?");
                    int id = Convert.ToInt32(Console.ReadLine());
                    string insercion = "insert into series values " +
                        "("+id+", "+nombre+", "+genero+", "+anyo+");";
                    cmd = new SQLiteCommand(insercion, conexion);
                    int cantidad = cmd.ExecuteNonQuery();
                    if (cantidad < 1)
                        Console.WriteLine("No guardado");
                    break;
                case "2":
                    string selectTodo = "select id, titulo, genero, anyo from series;";
                    cmd = new SQLiteCommand(selectTodo, conexion);
                    SQLiteDataReader datos = cmd.ExecuteReader();
                    while (datos.Read())
                    {
                        Console.WriteLine(datos[1] + " " + datos[3]);
                    }
                    break;
                default:
                    continuar = false;
                    break;
            }

        }
        conexion.Close();
    }
}
