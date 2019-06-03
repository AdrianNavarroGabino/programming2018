// Adrián Navarro Gabino

using System;
using System.Text;
using System.Collections.Generic;
using System.IO;
using System.Data.SQLite;

public class HomeAccounting
{
    static SQLiteCommand cmd;
    static SQLiteConnection conexion;

    public struct ExpensesIncomes : IComparable<ExpensesIncomes>
    {
        public int id;
        public string date;
        public string description;
        public string category;
        public float amount;

        public int CompareTo(ExpensesIncomes other)
        {
            if (date != other.date)
                return String.Compare(date, other.date);
            else
                return String.Compare(description, other.description, true);
        }
    }


    public static void AddExpense()
    {
        Console.Write("Enter the date: ");
        string date = Console.ReadLine();
        while ((Convert.ToInt32(date.Substring(0, 4)) < 1000 ||
            Convert.ToInt32(date.Substring(0, 4)) > 3000) ||
            (Convert.ToInt32(date.Substring(4, 2)) < 1 ||
            Convert.ToInt32(date.Substring(4, 2)) > 12) ||
            Convert.ToInt32(date.Substring(6, 2)) < 1 ||
            Convert.ToInt32(date.Substring(6, 2)) > 31)
        {
            Console.Write("Enter the date for " +
                "the expense again: ");
            date = Console.ReadLine();
        }

        Console.Write("Enter the description: ");
        string description = Console.ReadLine();
        while (description == "")
        {
            Console.Write("Enter the description again: ");
            description = Console.ReadLine();
        }

        Console.Write("Enter the category: ");
        string category = Console.ReadLine();

        Console.Write("Enter the amount: ");
        float amount = Convert.ToSingle(Console.ReadLine());

        Console.Write("Enter the id: ");
        int id = Convert.ToInt32(Console.ReadLine());

        conexion =
              new SQLiteConnection
              ("Data Source=home.sqlite;Version=3;New=False;Compress=True;");
        conexion.Open();
        string insert = "insert into home (id, fecha, descripcion," +
            "categoria, cantidad) values (" + id + ",\"" + date + "\", \"" +
            description + "\", \"" + category + "\", " + amount + ")";
        cmd = new SQLiteCommand(insert, conexion);
        int insertar = cmd.ExecuteNonQuery();

        if(insertar < 1)
        {
            Console.WriteLine("Error");
        }
        conexion.Close();
    }


    public static void ShowRecords()
    {
        Console.Write("Enter the category to search: ");
        string category = Console.ReadLine().ToUpper();
        Console.Write("Enter the first date: ");
        string firstDate = Console.ReadLine();
        Console.Write("Enter the second date: ");
        string secondDate = Console.ReadLine();
        Console.WriteLine();

        conexion =
              new SQLiteConnection
              ("Data Source=home.sqlite;Version=3;New=False;Compress=True;");
        conexion.Open();
        string leer = "select * from home where categoria = \"%" +
            category + "%\" and fecha >= \"" + firstDate +
            "\" and fecha <= \"" + secondDate + "\" order by fecha, descripcion;";
        cmd = new SQLiteCommand(leer, conexion);
        SQLiteDataReader datos = cmd.ExecuteReader();

        while (datos.Read())
        {
            Console.WriteLine("Record {0}.-{1}/{2}/{3}-{4}", Convert.ToInt32(datos[0]),
                    datos[1].ToString(),
                    datos[2].ToString(),
                    datos[3].ToString(),
                    Convert.ToSingle(datos[4]));
        }

        conexion.Close();
    }


    public static void SearchExpense()
    {
        Console.Write("Enter the text to search: ");
        string text = Console.ReadLine().ToUpper();
        Console.WriteLine();

        conexion =
              new SQLiteConnection
              ("Data Source=home.sqlite;Version=3;New=False;Compress=True;");
        conexion.Open();
        string leer = "select * from home where categoria like \"%" +
            text + "%\" or descripcion like \"%" +
            text + "%\" order by fecha, descripcion;";
        cmd = new SQLiteCommand(leer, conexion);
        SQLiteDataReader datos = cmd.ExecuteReader();

        while (datos.Read())
        {
            Console.WriteLine("Record {0}.-{1}/{2}/{3}-{4}", Convert.ToInt32(datos[0]),
                    datos[1].ToString(),
                    datos[2].ToString(),
                    datos[3].ToString(),
                    Convert.ToSingle(datos[4]));
        }
        conexion.Close();
    }


    public static void ModifyRecord()
    {
        Console.Write("Enter the number of record to modify: ");
        int modify = Convert.ToInt32(Console.ReadLine());
        
        Console.WriteLine("New Date:");
        string newDate = Console.ReadLine();

        Console.WriteLine("New description:");
        string newDecription = Console.ReadLine();

        Console.WriteLine("New category:");
        string newCategory = Console.ReadLine();

        Console.WriteLine("New amount: ");
        string newAmount = Console.ReadLine();

        conexion =
              new SQLiteConnection
              ("Data Source=home.sqlite;Version=3;New=False;Compress=True;");
        conexion.Open();
        string insert = "update home set fecha = \"" + newDate +
            "\", descripcion = \"" + newDecription + "\", categoria = \"" +
            newCategory + "\", cantidad = " + newAmount + " where id = " +
            modify + ";";
        cmd = new SQLiteCommand(insert, conexion);
        int insertar = cmd.ExecuteNonQuery();
        conexion.Close();
    }


    public static void DeleteRecord()
    {
        Console.Write("Enter the number of record to delete: ");
        int delete = Convert.ToInt32(Console.ReadLine());

        conexion =
              new SQLiteConnection
              ("Data Source=home.sqlite;Version=3;New=False;Compress=True;");
        conexion.Open();
        string borrar = "delete from home where id = " + delete + ";";
        cmd = new SQLiteCommand(borrar, conexion);
        int insertar = cmd.ExecuteNonQuery();
        conexion.Close();
    }

    public static void SortRecord()
    {
        Console.WriteLine("Already sorted");
    }


    public static void NormalizeDescriptions(List<ExpensesIncomes> e)
    {
        for (int i = 0; i < e.Count; i++)
        {
            ExpensesIncomes expenseNormalize = e[i];
            while (expenseNormalize.description.Contains("  "))
            {
                expenseNormalize.description = e[i].description.Replace(
                    "  ", " ");
            }
            expenseNormalize.description =
                expenseNormalize.description.Trim();
            if (expenseNormalize.description.CompareTo(
                expenseNormalize.description.ToUpper()) == 0)
            {
                expenseNormalize.description =
                    expenseNormalize.description.ToLower();
                StringBuilder description = new StringBuilder(
                    expenseNormalize.description);
                description[0] = Char.ToUpper(description[0]);
                expenseNormalize.description = Convert.ToString(
                    description);
            }
            e[i] = expenseNormalize;
        }

        Console.WriteLine("Descriptions are normalized");
    }

    public static void Main()
    {
        string[] options = {"Add new Expense",
            "Show records for category and dates","Search Expense",
            "Modify record","Delete record","Sort records",
            "Normalize descriptions"};
        char option;

    if (!File.Exists("home.sqlite"))
        {
            conexion =
             new SQLiteConnection
             ("Data Source=home.sqlite;Version=3;New=True;Compress=True;");
            conexion.Open();
            string creacion = "create table home ("
               + "id int primary key, fecha varchar(30),descripcion varchar(50),categoria varchar(25),cantidad int);";
            cmd = new SQLiteCommand(creacion, conexion);
            int cantidad = cmd.ExecuteNonQuery();
            conexion.Close();
        }
        else
        {
            do
            {
                Console.WriteLine("MENU");
                for (int i = 0; i < options.Length; i++)
                {
                    Console.WriteLine("{0}. {1}", i + 1, options[i]);
                }
                Console.WriteLine("T. Exit");
                Console.Write("Select Option: ");
                option = Convert.ToChar(Console.ReadLine());

                switch (option)
                {
                    case 'T': Console.WriteLine("Good Bye!!!"); break;
                    case '1':
                        AddExpense();
                        break;
                    case '2':
                        ShowRecords();
                        break;
                    case '3':
                        SearchExpense();
                        break;
                    case '4':
                        ModifyRecord();
                        break;
                    case '5':
                        DeleteRecord();
                        break;
                    case '6':
                        SortRecord();
                        break;
                    case '7':
                        break;
                    default: Console.WriteLine("Unknown option"); break;
                }
                Console.WriteLine();
            } while (option != 'T');
        }
    }
}
