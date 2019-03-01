// Adrián Navarro Gabino

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Books
{
    struct books
    {
        public string title;
        public string author;
        public int year;
    }
    class Program
    {
        static void Main(string[] args)
        {
            const int SIZE = 25000;
            books[] b = new books[SIZE];
            int actualBook = 0;

            const string ADD = "1";
            const string SHOW = "2";
            const string SEARCH = "3";
            const string SEARCH_DATE = "4";
            const string EDIT = "5";
            const string DELETE = "6";
            const string ORTO_ERRORS = "7";
            const string EXIT = "Q";

            string option = "";

            do
            {
                Console.WriteLine("Choose an option:");
                Console.WriteLine("1. Add a book");
                Console.WriteLine("2. Show all books");
                Console.WriteLine("3. Search a book");
                Console.WriteLine("4. Search a book by a range of dates");
                Console.WriteLine("5. Edit a book");
                Console.WriteLine("6. Delete a book");
                Console.WriteLine("7. Find possible spelling mistakes");
                option = Console.ReadLine();

                switch(option)
                {
                    case ADD:
                        if (actualBook >= SIZE)
                        {
                            Console.WriteLine("Database full");
                        }
                        else
                        {
                            do
                            {
                                Console.Write("Enter the title: ");
                                b[actualBook].title = Console.ReadLine();
                            } while (b[actualBook].title == "");

                            do
                            {
                                Console.Write("Enter the author: ");
                                b[actualBook].author = Console.ReadLine();
                            } while (b[actualBook].title == "");

                            Console.Write("Enter the year of publication: ");
                            string auxYear = Console.ReadLine();
                            if (auxYear == "")
                            {
                                b[actualBook].year = -1;
                            }
                            else
                            {
                                b[actualBook].year = Convert.ToInt32(auxYear);
                            }
                            

                            for(int i = 0; i < actualBook - 1; i++)
                            {
                                for(int j = i + 1; i < actualBook; j++)
                                {
                                    if(b[i].title.CompareTo(b[j].title) > 0)
                                    {
                                        books aux = b[i];
                                        b[i] = b[j];
                                        b[j] = aux;
                                    }
                                    else if(
                                        b[i].title.CompareTo(b[j].title) == 0)
                                    {
                                        if (b[i].author.CompareTo(b[j].author) > 0)
                                        {
                                            books aux = b[i];
                                            b[i] = b[j];
                                            b[j] = aux;
                                        }
                                    }
                                }
                            }
                        }

                        actualBook++;
                        Console.WriteLine();
                        break;
                    case SHOW:
                        if(actualBook == 0)
                        {
                            Console.WriteLine("Database empty");
                        }
                        else
                        {
                            for(int i = 0; i < actualBook; i++)
                            {
                                Console.WriteLine("Book number " + (i+1) + "-"
                                    + b[i].title + "-" + b[i].author + "-" + 
                                    b[i].year.ToString().Replace("-1","Año desconocido"));

                                if(i % 21 == 20)
                                {
                                    Console.ReadLine();
                                }
                            }
                        }

                        Console.WriteLine();
                        break;
                    case SEARCH:
                        int countSearch = 0;

                        Console.WriteLine("Which book do you want to search?");
                        string textToSearch = Console.ReadLine();

                        for(int i = 0; i < actualBook; i++)
                        {
                            if(b[i].title.ToUpper().Contains(textToSearch.ToUpper()) ||
                                b[i].author.ToUpper().Contains(textToSearch.ToUpper()))
                            {
                                countSearch++;

                                Console.WriteLine("Book number " + (i + 1) + "-"
                                    + b[i].title + "-" + b[i].author + "-" +
                                    b[i].year.ToString().Replace("-1", "Año desconocido"));

                                if (countSearch % 21 == 20)
                                {
                                    Console.ReadLine();
                                }
                            }
                        }

                        Console.WriteLine();
                        break;
                    case SEARCH_DATE:
                        Console.Write("Enter the first date: ");
                        int date1 = Convert.ToInt32(Console.ReadLine());

                        Console.Write("Enter the second date: ");
                        int date2 = Convert.ToInt32(Console.ReadLine());

                        if(date1 > date2)
                        {
                            int auxDate = date1;
                            date1 = date2;
                            date2 = auxDate;
                        }

                        for(int i = 0; i < actualBook; i++)
                        {
                            if(b[i].year >= date1 && b[i].year <= date2)
                            {
                                Console.WriteLine("Book number " + (i + 1) + "-"
                                    + b[i].title + "-" + b[i].author + "-" +
                                    b[i].year.ToString().Replace("-1", "Año desconocido"));
                            }
                        }

                        Console.WriteLine();
                        break;
                    case EDIT:
                        Console.WriteLine("Enter the number of the book:");
                        int bookEdit = Convert.ToInt32(Console.ReadLine()) - 1;
                        if (bookEdit >= actualBook)
                        {
                            Console.WriteLine("Wrong number");
                        }
                        else
                        {
                            Console.WriteLine("Old title: " + b[bookEdit].title);
                            Console.WriteLine("New title:");
                            string auxEdit = Console.ReadLine().Trim();
                            if (auxEdit != "")
                            {
                                b[bookEdit].title = auxEdit;
                            }

                            Console.WriteLine("Old author: " + b[bookEdit].author);
                            Console.WriteLine("New author:");
                            auxEdit = Console.ReadLine().Trim();
                            if (auxEdit != "")
                            {
                                b[bookEdit].author = auxEdit;
                                if(b[bookEdit].author.CompareTo(b[bookEdit].author.ToUpper()) == 0
                                    || b[bookEdit].author.CompareTo(b[bookEdit].author.ToLower()) == 0
                                    || b[bookEdit].author.Contains("  "))
                                {
                                    Console.WriteLine("Error: Upper, Lower or spaces");
                                }
                            }

                            Console.WriteLine("Old year of publication: " +
                                b[bookEdit].year);
                            Console.WriteLine("New year of publication:");
                            auxEdit = Console.ReadLine();
                            if (auxEdit != "")
                            {
                                b[bookEdit].year = Convert.ToInt32(auxEdit);
                            }
                        }

                        Console.WriteLine();
                        break;
                    case DELETE:
                        Console.WriteLine("Enter the number of the book:");
                        int bookDelete = Convert.ToInt32(Console.ReadLine()) - 1;
                        if (bookDelete >= actualBook)
                        {
                            Console.WriteLine("Wrong number");
                        }
                        else
                        {
                            Console.WriteLine("Book number " + (bookDelete + 1) + "-"
                                    + b[bookDelete].title + "-" + b[bookDelete].author + "-" +
                                    b[bookDelete].year.ToString().Replace("-1", "Año desconocido"));
                            Console.Write("Are you sure? (s/n): ");
                            string areYouSure = Console.ReadLine();

                            if(areYouSure.CompareTo("s") == 0)
                            {
                                for(int i = bookDelete; i < actualBook; i++)
                                {
                                    b[i] = b[i + 1];
                                }
                            }
                        }

                        actualBook--;
                        Console.WriteLine();
                        break;
                    case ORTO_ERRORS:
                        for (int i = 0; i < actualBook; i++)
                        {
                            bool consecutiveSpaces = false;
                            bool notTrim = false;
                            bool capitalLetter = false;

                            if(b[i].title.Contains("  ") ||
                                b[i].author.Contains("  "))
                            {
                                consecutiveSpaces = true;
                            }

                            if (b[i].title[0] == ' ' || b[i].author[0] == ' '
                                || b[i].title[b[i].title.Length - 1] == ' ' ||
                                b[i].author[b[i].author.Length - 1] == ' ')
                            {
                                notTrim = true;
                            }

                            for (int j = 0; i < b[i].title.Length - 1; j++)
                            {
                                string auxChain = "" + b[i].title[j];
                                auxChain += b[i].title[j + 1];
                                if (b[i].title.Substring(j, 1).CompareTo(
                                    b[i].title.Substring(j, 1).ToLower()) == 0
                                    && b[i].title.Substring(j + 1, 1).CompareTo(
                                    b[i].title.Substring(j + 1, 1).ToUpper()) == 0)
                                {
                                    capitalLetter = true;
                                }
                            }

                            for (int j = 0; i < b[i].author.Length - 1; j++)
                            {
                                string auxChain = "" + b[i].author[j];
                                auxChain += b[i].author[j + 1];
                                if (b[i].author.Substring(j, 1).CompareTo(
                                    b[i].author.Substring(j, 1).ToLower()) == 0
                                    && b[i].author.Substring(j + 1, 1).CompareTo(
                                    b[i].author.Substring(j + 1, 1).ToUpper()) == 0)
                                {
                                    capitalLetter = true;
                                }
                            }

                            if (consecutiveSpaces || notTrim || capitalLetter)
                            {
                                Console.WriteLine("Do you want to correct" +
                                    " the book number " + (i+1) + "?(s/n)");
                                string yesOrNot = Console.ReadLine();

                                if(yesOrNot.CompareTo("s") == 0)
                                {
                                    b[i].title = b[i].title.Trim();
                                    b[i].author = b[i].author.Trim();
                                    
                                    while(b[i].title.Contains("  "))
                                    {
                                        b[i].title.Replace("  ", " ");
                                    }
                                    while (b[i].author.Contains("  "))
                                    {
                                        b[i].author.Replace("  ", " ");
                                    }

                                    b[i].title = b[i].title.ToLower();
                    
                                    b[i].title = Char.ToUpper(b[i].title[0])
                                        + b[i].title.Substring(1, b[i].title.Length - 1);
                                    StringBuilder auxChain = new StringBuilder(b[i].title);
                                    for(int j = 0; j < auxChain.Length; j++)
                                    {
                                        if(auxChain[j] == '.')
                                        {
                                            auxChain[j + 2] = Char.ToUpper(auxChain[j + 2]);
                                        }
                                    }

                                    b[i].title = auxChain.ToString();

                                    b[i].author = b[i].author.ToLower();

                                    b[i].author = Char.ToUpper(b[i].author[0])
                                        + b[i].author.Substring(1, b[i].author.Length - 1);
                                    StringBuilder auxChain2 = new StringBuilder(b[i].author);
                                    for (int j = 0; j < auxChain2.Length; j++)
                                    {
                                        if (auxChain2[j] == '.')
                                        {
                                            auxChain2[j + 2] = Char.ToUpper(auxChain2[j + 2]);
                                        }
                                    }

                                    b[i].author = auxChain2.ToString();
                                }
                            }
                        }

                        Console.WriteLine();
                        break;
                    case EXIT:
                        Console.WriteLine("Bye!");
                        break;
                }

                
            } while (option != "Q");
        }
    }
}
