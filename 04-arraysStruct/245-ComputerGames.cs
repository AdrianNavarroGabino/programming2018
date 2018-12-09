// Adrián Navarro Gabino

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
        int actualGame = 0;

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
                    if(actualGame >= SIZE)
                        Console.WriteLine("Database full");
                    else
                    {
                        Console.WriteLine("Game #" + (actualGame + 1));
                        do
                        {
                            Console.Write("Enter the title: ");
                            g[actualGame].title = Console.ReadLine();
                        } while (g[actualGame].title == "");

                        do
                        {
                            Console.Write("Enter the category: ");
                            g[actualGame].category = Console.ReadLine();
                        } while (g[actualGame].category == "");

                        Console.Write("Enter the platform: ");
                        g[actualGame].platform = Console.ReadLine();

                        do
                        {
                            Console.Write("Enter the year: ");
                            g[actualGame].year = Convert.ToInt32(Console.ReadLine());
                        } while (g[actualGame].year < 1940 || g[actualGame].year > 2100);

                        do
                        {
                            Console.Write("Enter the rating: ");
                            g[actualGame].rating = Convert.ToDouble(Console.ReadLine());
                        } while (g[actualGame].rating < 0 || g[actualGame].rating > 10);

                        Console.WriteLine("Enter comments:");
                        g[actualGame].comments = Console.ReadLine();

                        actualGame++;
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

                        for(int i = 0; i < actualGame; i++)
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
                        if (showPosition >= actualGame)
                            Console.WriteLine("Wrong number");
                        else
                        {
                            Console.WriteLine("Game #" + (actualGame + 1));
                            Console.WriteLine("Title: " + g[actualGame].title);
                            Console.WriteLine("Category: " + g[actualGame].category);
                            Console.WriteLine("Platform: " + g[actualGame].platform);
                            Console.WriteLine("Year: " + g[actualGame].year);
                            Console.WriteLine("Rating: " + g[actualGame].rating);
                            Console.WriteLine("Comments: " + g[actualGame].comments);

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

                    for(int i = 0; i < actualGame; i++)
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

                    for(int i = 0; i < actualGame; i++)
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

                    if(modify >= actualGame)
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

                    if(delete >= actualGame)
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
                            for(int i = delete; i < actualGame; i++)
                            {
                                g[i] = g[i + 1];
                            }

                            actualGame--;
                        }
                    }

                    Console.WriteLine();
                    break;
                case SORT:
                    for(int i = 0; i < actualGame - 1; i++)
                    {
                        for(int j = i + 1; j < actualGame; j++)
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
                    for(int i = 0; i < actualGame; i++)
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
        } while (option != "Q");
    }
}
