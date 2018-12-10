// Adrián Navarro Gabino

/*
Create a C# program that can store up to 10000 computer games and other 
software. For each game, it must allow the user to store the following 
information:
    * Title (e.g. GranTurismo 6)
    * Category (e.g. Racing)
    * Platform (e.g. PS3)
    * Year (e.g. 2013)
    * Rating (e.g. 8.7)
    * Comments
The program should allow the user to perform the following operations :
1 - Add a new game (at the end of the existing data). The title and description 
cannot be empty. The year, if entered, must be from 1940 to 2100. The rating, 
if entered, must be 0 to 10. No other validation must be done.
2 - Show all the data of a certain game (chose by number o exact title, case 
insensitive).
3 - Show all the games of a certain platform and category. You must display the 
record number, the title, year and rating, pausing after every 22 rows. 
4 - Find games containing a certain text (partial search, in any text field, 
not case sensitive). You must display the record number, the title, year and 
rating, pausing after every 22 rows.
5 - Update a record: ask the user for its number, display the previous value of 
each field and allow the user to press Enter not to modify any of the data. The 
user should be warned (but not asked again) if he enters an incorrect record 
number. The year and rating, if entered, must be valid.
6 - Delete a record, in the position entered by the user. He should be warned 
(but not asked again) if he enters an incorrect record number. It should 
display the record to be deleted and ask for confirmation before the deletion.
7 - Sort data alphabetically, by title and (if necessary) platform.
8 - Eliminate redundant spaces: remove trailing spaces, leading spaces and 
duplicate spaces in description, category and platform.
Q - Quit the application (as we do not store the information on file, data will 
be lost). 
*/

using System;

public class ComputerGames
{
    struct game
    {
        public string title;
        public string category;
        public string platform;
        public int year;
        public double rating;
        public string comments;
    }
    public static void Main()
    {
        const int SIZE = 1000;
        game[] g = new game[SIZE];

        const string ADD = "1";
        const string SHOW_GAME = "2";
        const string SHOW_ALL = "3";
        const string SEARCH = "4";
        const string MODIFY = "5";
        const string DELETE = "6";
        const string SORT = "7";
        const string TRIM = "8";
        const string EXIT = "Q";

        string option;
        int currentGame = 0;

        do
        {
            Console.WriteLine("Choose an option:");
            Console.WriteLine("1 - Add a new game");
            Console.WriteLine("2 - Show all the data of a certain game");
            Console.WriteLine("3 - Show all the games of a certain platform and category");
            Console.WriteLine("4 - Find games containing a certain text");
            Console.WriteLine("5 - Update a record");
            Console.WriteLine("6 - Delete a record");
            Console.WriteLine("7 - Sort data alphabetically");
            Console.WriteLine("8 - Eliminate redundant spaces");
            Console.WriteLine("Q - Quit the application");

            Console.WriteLine();
            option = Console.ReadLine();
            Console.WriteLine();

            switch(option)
            {
                case ADD:
                    if(currentGame >= SIZE)
                        Console.WriteLine("Database full");
                    else
                    {
                        Console.WriteLine("Game #" + (currentGame + 1));
                        do
                        {
                            Console.Write("Enter the title: ");
                            g[currentGame].title = Console.ReadLine();
                        } while (g[currentGame].title == "");

                        do
                        {
                            Console.Write("Enter the category: ");
                            g[currentGame].category = Console.ReadLine();
                        } while (g[currentGame].category == "");

                        Console.Write("Enter the platform: ");
                        g[currentGame].platform = Console.ReadLine();

                        do
                        {
                            Console.Write("Enter the year: ");
                            g[currentGame].year = Convert.ToInt32(Console.ReadLine());
                        } while (g[currentGame].year < 1940 || g[currentGame].year > 2100);

                        do
                        {
                            Console.Write("Enter the rating: ");
                            g[currentGame].rating = Convert.ToDouble(Console.ReadLine());
                        } while (g[currentGame].rating < 0 || g[currentGame].rating > 10);

                        Console.WriteLine("Enter comments:");
                        g[currentGame].comments = Console.ReadLine();

                        currentGame++;
                    }

                    Console.WriteLine();
                    break;
                case SHOW_GAME:
                    int showPosition = -1;

                    Console.WriteLine("Choose an option:");
                    Console.WriteLine("1- Search by number");
                    Console.WriteLine("2- Search by title");

                    int showOption = Convert.ToInt32(Console.ReadLine());

                    if(showOption == 1)
                    {
                        Console.Write("Enter the number: ");
                        showPosition = Convert.ToInt32(Console.ReadLine()) - 1;
                    }
                    else if(showOption == 2)
                    {
                        Console.Write("Enter the title: ");
                        string showTitle = Console.ReadLine().ToLower();

                        for(int i = 0; i < currentGame; i++)
                        {
                            if (g[i].title.ToLower() == showTitle)
                                showPosition = i;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Wrong option");
                    }

                    if (showPosition != -1)
                    {
                        if (showPosition >= currentGame)
                            Console.WriteLine("Wrong number");
                        else
                        {
                            Console.WriteLine("Game #" + (currentGame + 1));
                            Console.WriteLine("Title: " + g[currentGame].title);
                            Console.WriteLine("Category: " + g[currentGame].category);
                            Console.WriteLine("Platform: " + g[currentGame].platform);
                            Console.WriteLine("Year: " + g[currentGame].year);
                            Console.WriteLine("Rating: " + g[currentGame].rating);
                            Console.WriteLine("Comments: " + g[currentGame].comments);

                            Console.WriteLine();
                        }
                    }

                    Console.WriteLine();
                    break;
                case SHOW_ALL:
                    int showCount = 0;

                    Console.Write("Enter platform: ");
                    string showPlatform = Console.ReadLine().ToLower();

                    Console.Write("Enter category: ");
                    string showCategory = Console.ReadLine().ToLower();

                    for(int i = 0; i < currentGame; i++)
                    {
                        if(g[i].platform.ToLower() == showPlatform && g[i].category.ToLower() == showCategory)
                        {
                            showCount++;

                            Console.WriteLine("Game #" + (i + 1));
                            Console.WriteLine("Title: " + g[i].title);
                            Console.WriteLine("Year: " + g[i].year);
                            Console.WriteLine("Rating: " + g[i].rating);

                            if(showCount % 23 == 22)
                            {
                                Console.ReadLine();
                            }
                        }
                    }

                    Console.WriteLine();
                    break;
                case SEARCH:
                    int searchCount = 0;

                    Console.Write("Text to search: ");
                    string search = Console.ReadLine().ToLower();

                    for(int i = 0; i < currentGame; i++)
                    {
                        if(
                                g[i].title.ToLower().Contains(search) ||
                                g[i].category.ToLower().Contains(search) ||
                                g[i].platform.ToLower().Contains(search) ||
                                g[i].year.ToString().Contains(search) ||
                                g[i].rating.ToString().Contains(search) ||
                                g[i].comments.ToLower().Contains(search))
                        {
                            searchCount++;

                            Console.WriteLine("Game #" + (i + 1));
                            Console.WriteLine("Title: " + g[i].title);
                            Console.WriteLine("Year: " + g[i].year);
                            Console.WriteLine("Rating: " + g[i].rating);

                            if (searchCount % 23 == 22)
                            {
                                Console.ReadLine();
                            }
                        }
                    }

                    Console.WriteLine();
                    break;
                case MODIFY:
                    Console.Write("Enter number to modify: ");
                    int modify = Convert.ToInt32(Console.ReadLine()) - 1;

                    if(modify >= currentGame)
                    {
                        Console.WriteLine("Wrong number");
                    }
                    else
                    {
                        string modifyAux;

                        Console.WriteLine("Game #" + (modify + 1));

                        Console.WriteLine("Title: " + g[modify].title);
                        Console.Write("New title: ");
                        modifyAux = Console.ReadLine();
                        if(modifyAux != "")
                        {
                            g[modify].title = modifyAux;
                        }

                        Console.WriteLine("Category: " + g[modify].category);
                        Console.Write("New category: ");
                        modifyAux = Console.ReadLine();
                        if (modifyAux != "")
                        {
                            g[modify].category = modifyAux;
                        }

                        Console.WriteLine("Platform: " + g[modify].platform);
                        Console.Write("New platform: ");
                        modifyAux = Console.ReadLine();
                        if (modifyAux != "")
                        {
                            g[modify].platform = modifyAux;
                        }

                        Console.WriteLine("Year: " + g[modify].year);
                        Console.Write("New year: ");
                        modifyAux = Console.ReadLine();
                        if (modifyAux != "")
                        {
                            try
                            {
                                if(Convert.ToInt32(modifyAux) >= 1940 &&
                                        Convert.ToInt32(modifyAux) <= 2100)
                                    g[modify].year = Convert.ToInt32(modifyAux);
                                else
                                {
                                    Console.WriteLine("Wrong year");
                                }
                            }
                            catch(Exception)
                            {
                                Console.WriteLine("Wrong year");
                            }
                        }

                        Console.WriteLine("Rating: " + g[modify].rating);
                        Console.Write("New rating: ");
                        modifyAux = Console.ReadLine();
                        if (modifyAux != "")
                        {
                            try
                            {
                                if (Convert.ToDouble(modifyAux) >= 0 &&
                                        Convert.ToDouble(modifyAux) <= 10)
                                    g[modify].rating = Convert.ToDouble(modifyAux);
                                else
                                {
                                    Console.WriteLine("Wrong year");
                                }
                            }
                            catch (Exception)
                            {
                                Console.WriteLine("Wrong year");
                            }
                        }

                        Console.WriteLine("Comments: " + g[modify].comments);
                        Console.Write("New comments: ");
                        modifyAux = Console.ReadLine();
                        if (modifyAux != "")
                        {
                            g[modify].comments = modifyAux;
                        }

                    }

                    Console.WriteLine();
                    break;
                case DELETE:
                    Console.Write("Enter the number to delete: ");
                    int delete = Convert.ToInt32(Console.ReadLine()) - 1;

                    if(delete >= currentGame)
                        Console.WriteLine("Wrong number");
                    else
                    {
                        Console.WriteLine("Game #" + (delete + 1));
                        Console.WriteLine("Title: " + g[delete].title);
                        Console.WriteLine("Category: " + g[delete].category);
                        Console.WriteLine("Platform: " + g[delete].platform);
                        Console.WriteLine("Year: " + g[delete].year);
                        Console.WriteLine("Rating: " + g[delete].rating);
                        Console.WriteLine("Comments: " + g[delete].comments);
                        Console.WriteLine();

                        Console.WriteLine("Are you sure?(y/n): ");
                        string confirmation = Console.ReadLine().ToLower();

                        if(confirmation == "y")
                        {
                            for(int i = delete; i < currentGame; i++)
                            {
                                g[i] = g[i + 1];
                            }

                            currentGame--;
                        }
                    }

                    Console.WriteLine();
                    break;
                case SORT:
                    for(int i = 0; i < currentGame - 1; i++)
                    {
                        for(int j = i + 1; j < currentGame; j++)
                        {
                            if(g[i].title.CompareTo(g[j].title) > 0)
                            {
                                game aux = g[i];
                                g[i] = g[j];
                                g[j] = aux;
                            }
                            else if(g[i].title.CompareTo(g[j].title) == 0)
                            {
                                if (g[i].platform.CompareTo(g[j].platform) > 0)
                                {
                                    game aux = g[i];
                                    g[i] = g[j];
                                    g[j] = aux;
                                }
                            }
                        }
                    }

                    Console.WriteLine();
                    break;
                case TRIM:
                    for(int i = 0; i < currentGame; i++)
                    {
                        g[i].title = g[i].title.Trim();
                        while(g[i].title.Contains("  "))
                        {
                            g[i].title = g[i].title.Replace("  ", " ");
                        }

                        g[i].category = g[i].category.Trim();
                        while (g[i].category.Contains("  "))
                        {
                            g[i].category = g[i].category.Replace("  ", " ");
                        }

                        g[i].platform = g[i].platform.Trim();
                        while (g[i].platform.Contains("  "))
                        {
                            g[i].platform = g[i].platform.Replace("  ", " ");
                        }
                    }

                    Console.WriteLine();
                    break;
                case EXIT:
                    Console.WriteLine("Bye!");

                    Console.WriteLine();
                    break;
                default:
                    Console.WriteLine("Wrong option");
                    Console.WriteLine();
                    break;
            }
        } while (option != EXIT);
    }
}
