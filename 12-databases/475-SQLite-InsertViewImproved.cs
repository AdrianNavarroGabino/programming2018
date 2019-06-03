// Adrián Navarro Gabino

using System;
using System.Data.SQLite;
using System.IO;
using System.Threading;

class SeriesDataBase
{
    static void Main(string[] args)
    {
        int id = -1;
        byte option;
        SQLiteConnection conexion; 
        SQLiteCommand cmd;

        if (!File.Exists("series.sqlite"))
        {
            conexion =
              new SQLiteConnection
              ("Data Source=series.sqlite;Version=3;New=true;Compress=True;");
            conexion.Open();
            string creacion = "create table series ("
               + " id int primary key,titulo varchar(50)," +
               "genero varchar(25),anyo int);";
            cmd = new SQLiteCommand(creacion, conexion);

            cmd.ExecuteNonQuery();
            id = 0;
            Console.WriteLine("Table created successfully.");
            Thread.Sleep(1000);
            Console.Clear();
        }
        else
        {
            conexion = new SQLiteConnection
                ("Data Source=series.sqlite;Version=3;New=false;Compress=True;");
            conexion.Open();
        }
        do
        {
            Console.WriteLine("MENU");
            Console.WriteLine("1. Add Serie");
            Console.WriteLine("2. Show all Series");
            Console.WriteLine("0. Exit");
            Console.Write("Option: ");
            option = Convert.ToByte(Console.ReadLine());
            Console.WriteLine();

            if (option == 1)
            {
                Console.Write("Enter the title: ");
                string title = Console.ReadLine();
                Console.Write("Enter the genre: ");
                string genre = Console.ReadLine();
                Console.Write("Enter the premiere year: ");
                int year = Convert.ToInt32(Console.ReadLine());


                if (id != 0)
                {
                    string idMax = "select max(id) from series;";
                    cmd = new SQLiteCommand(idMax, conexion);
                    SQLiteDataReader maxId = cmd.ExecuteReader();
                    id = Convert.ToInt32(maxId[0]) + 1;
                }

                string insercion = "insert into series (id,titulo,genero,anyo)" +
                    " values(" + id + ",'" + title + "','" + genre + "'," + year + ");";
                cmd = new SQLiteCommand(insercion, conexion);
                //Console.WriteLine(insercion);
                int cantidad = cmd.ExecuteNonQuery();
                if (cantidad < 1)
                {
                    Console.WriteLine("Serie not inserted!!!");
                }
                else
                {
                    Console.WriteLine("Serie inserted successfully!!!");
                }

            }
            else if (option == 2)
            {
                string leer = "select * from series;";
                cmd = new SQLiteCommand(leer, conexion);
                SQLiteDataReader datos = cmd.ExecuteReader();

                Console.WriteLine("----------------------------");
                while (datos.Read())
                {
                    int ids = Convert.ToInt32(datos[0]);
                    string title = Convert.ToString(datos[1]);
                    string genre = Convert.ToString(datos[2]);
                    int year = Convert.ToInt32(datos[3]);
                    Console.WriteLine("Id: " + ids);
                    Console.WriteLine("Title: " + title);
                    Console.WriteLine("Genre: " + genre);
                    Console.WriteLine("Year: " + year);
                    Console.WriteLine("----------------------------");
                }
            }
            else if (option == 0)
            {
                Console.WriteLine("Good Bye!!!");
            }
            Console.WriteLine();
            
        } while (option != 0);
        conexion.Close();
    }
}
