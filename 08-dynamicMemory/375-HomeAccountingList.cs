// Adrián Navarro Gabino

using System;
using System.Text;
using System.Collections.Generic;

public class HomeAccountingList
{
    public struct ExpensesIncome : IComparable<ExpensesIncome>
    {
        public string date;
        public string description;
        public string category;
        public float amount;

        public int CompareTo(ExpensesIncome h1)
        {
            if (date != h1.date)
                return String.Compare(this.date, h1.date);
            else
                return String.Compare(this.description, h1.description, true);
        }
    }


    public static void AddExpense(List<ExpensesIncome> e)
    {
        try
        {
            ExpensesIncome aux;

            Console.Write("Enter the date for {0} expenditure: ",
                e.Count + 1);
            string date = Console.ReadLine();
            while ((Convert.ToInt32(date.Substring(0, 4)) < 1000 ||
                Convert.ToInt32(date.Substring(0, 4)) > 3000) ||
                (Convert.ToInt32(date.Substring(4, 2)) < 1 ||
                Convert.ToInt32(date.Substring(4, 2)) > 12) ||
                Convert.ToInt32(date.Substring(6, 2)) < 1 ||
                Convert.ToInt32(date.Substring(6, 2)) > 31)
            {
                Console.Write("Enter the date for {0} " +
                    "the expenditure again: ", e.Count + 1);
                date = Console.ReadLine();
            }
            aux.date = date;

            Console.Write("Enter the description for {0} " +
                "expenditure: ", e.Count + 1);
            string description = Console.ReadLine();
            while (description == "")
            {
                Console.Write("Enter the description for {0} " +
                "expenditure again: ");
                description = Console.ReadLine();
            }
            aux.description = description;

            Console.Write("Enter the category for {0} " +
            "expenditure: ", e.Count + 1);
            aux.category = Console.ReadLine();

            Console.Write("Enter the amount for {0} " +
            "expenditure: ", e.Count + 1);
            aux.amount = Convert.ToSingle(Console.ReadLine());

            e.Add(aux);
        }
        catch(Exception)
        {
            Console.WriteLine("Data base full");
        }
    }


    public static void ShowRecords(List<ExpensesIncome> e)
    {
        Console.Write("Enter the category to search: ");
        string category = Console.ReadLine().ToUpper();
        Console.Write("Enter the first date: ");
        string firstDate = Console.ReadLine();
        Console.Write("Enter the second date: ");
        string secondDate = Console.ReadLine();
        Console.WriteLine();
        bool isFound = false;
        float sumAmount = 0;
        for (int i = 0; i < e.Count; i++)
        {
            if (e[i].category.ToUpper().Contains(category) &&
                e[i].date.CompareTo(firstDate) >= 0 &&
                e[i].date.CompareTo(secondDate) <= 0)
            {
                isFound = true;
                Console.WriteLine("Record {0}.-{1}/{2}/{3}-{4}-({5})-{6}",
                    i + 1, e[i].date.Substring(6, 2),
                    e[i].date.Substring(4, 2),
                    e[i].date.Substring(0, 4), e[i].description,
                    e[i].category, e[i].amount.ToString("0.00"));
                sumAmount += e[i].amount;
            }
        }
        if (isFound)
            Console.WriteLine("\nTotal: {0}", sumAmount.ToString("0.00"));
        else
            Console.WriteLine("There aren't coincidences");
    }


    public static void SearchExpense(List<ExpensesIncome> e)
    {
        Console.Write("Enter the text to search: ");
        string text = Console.ReadLine().ToUpper();
        Console.WriteLine();
        bool isLocated = false;
        byte spaces = 0;
        for (int i = 0; i < e.Count; i++)
        {
            if (e[i].description.ToUpper().Contains(text) ||
                e[i].category.ToUpper().Contains(text))
            {
                isLocated = true;
                int j = 0;
                while (j < e[i].description.Length && spaces < 6)
                {
                    if (e[i].description[j] == ' ')
                    {
                        spaces++;
                    }
                    j++;
                }
                Console.WriteLine("Record {0}.-{1}/{2}/{3}-{4}", i + 1,
                    e[i].date.Substring(6, 2),
                    e[i].date.Substring(4, 2),
                    e[i].date.Substring(0, 4),
                    spaces == 6 ? e[i].description.Substring(0, j - 1) :
                    e[i].description);
            }
        }
        if (!isLocated)
            Console.WriteLine("Not found");
    }


    public static void ModifyRecord(List<ExpensesIncome> e)
    {
        ExpensesIncome auxModify;

        Console.Write("Enter the number of register to modify: ");
        int modify = Convert.ToInt32(Console.ReadLine()) - 1;
        if (modify < 0 || modify > e.Count - 1)
        {
            Console.WriteLine("Number of register incorrect");
        }
        else
        {
            Console.WriteLine("Register {0}:", modify + 1);
            Console.WriteLine("New Date was({0}/{1}/{2}): ",
                e[modify].date.Substring(6, 2),
                e[modify].date.Substring(4, 2),
                e[modify].date.Substring(0, 4));
            string newDate = Console.ReadLine();

            if (newDate != "")
                auxModify.date = newDate;
            else
                auxModify.date = e[modify].date;

            Console.WriteLine("New description was ({0}):",
                e[modify].description);
            string newDecription = Console.ReadLine();

            if (newDecription != "")
                auxModify.description = newDecription;
            else
                auxModify.description = e[modify].description;

            Console.WriteLine("New category was ({0}):",
                e[modify].category);
            string newCategory = Console.ReadLine();

            if (newCategory != "")
                auxModify.category = newCategory;
            else
                auxModify.category = e[modify].category;

            Console.WriteLine("New amount was ({0}): ",
                e[modify].amount);
            string newAmount = Console.ReadLine();

            if (newAmount != "")
                auxModify.amount = Convert.ToSingle(newAmount);
            else
                auxModify.amount = e[modify].amount;

            e[modify] = auxModify;
        }
    }


    public static void DeleteRecord(List<ExpensesIncome> e)
    {
        Console.Write("Enter the number of register to delete: ");
        int delete = Convert.ToInt32(Console.ReadLine()) - 1;

        try
        {
            Console.WriteLine("Register {0}:", delete + 1);
            Console.WriteLine("Date: {0}/{1}/{2}",
                e[delete].date.Substring(6, 2),
                e[delete].date.Substring(4, 2),
                e[delete].date.Substring(0, 4));
            Console.WriteLine("Description: {0}",
                e[delete].description);
            Console.WriteLine("Category: {0}",
                e[delete].category);
            Console.WriteLine("Amount: {0}",
                e[delete].amount);

            Console.WriteLine("Are you sure you want to " +
                        "delete the record?(Y/N): ");
            char secure = Char.ToUpper(Convert.ToChar(
                Console.ReadLine()));
            if (secure == 'Y')
            {
                for (int i = delete; i < e.Count; i++)
                {
                    e[i] = e[i + 1];
                }
                Console.WriteLine("Delete is completed");
            }
            else
                Console.WriteLine(
                            "The record hasn't been deleted");
        }
        catch(Exception)
        {
            Console.WriteLine("Number of register incorrect");
        }
    }


    public static void SortRecord(List<ExpensesIncome> e)
    {
        e.Sort();
        Console.WriteLine("Sorted!");
    }


    public static void NormalizeDescriptions(List<ExpensesIncome> e)
    {
        for (int i = 0; i < e.Count; i++)
        {
            ExpensesIncome expenseNormalize = e[i];
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
        List<ExpensesIncome> e = new List<ExpensesIncome>();
        string[] options = {"Add new Expense",
            "Show records for category and dates","Search Expense",
            "Modify record","Delete record","Sort records",
            "Normalize descriptions"};
        char option;

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
                    AddExpense(e);
                    break;
                case '2':
                    ShowRecords(e);
                    break;
                case '3':
                    SearchExpense(e);
                    break;
                case '4':
                    ModifyRecord(e);
                    break;
                case '5':
                    DeleteRecord(e);
                    break;
                case '6':
                    SortRecord(e);
                    break;
                case '7':
                    NormalizeDescriptions(e);
                    break;
                default: Console.WriteLine("Unknown option"); break;
            }
            Console.WriteLine();
        } while (option != 'T');

    }
}
