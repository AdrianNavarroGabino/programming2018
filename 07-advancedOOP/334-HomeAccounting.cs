// Javier Benajes, Adrián Navarro, Araceli Yañez

using System;

class Transaction
{
    public string Day { get; set; }
    public string Month { get; set; }
    public int Year { get; set; }
    public int Amount { get; set; }
    public string Description { get; set; }

    public Transaction(string day, string month, int year, int amount, string description)
    {
        this.Day = day;
        this.Month = month;
        this.Year = year;
        this.Amount = amount;
        this.Description = description;
    }
    
    public Transaction(string day, string month, int amount, string description)
    {
        this.Day = day;
        this.Month = month;
        this.Amount = amount;
        this.Description = description;
    }

    public override string ToString()
    {
        return "Day: " + Day + ", Month: " + Month + ", Year: " + Year + ", Amount: " + Amount + ", Description: " + Description;
    }
}

class RepetitiveTransaction : Transaction
{

    public RepetitiveTransaction(string day, string month,
        int amount, string description) : base(
        day, month, amount, description)
    {
    }
}

class TransactionList
{
    protected int amountOfTransactions;
    
    protected Transaction[] Transactions = new Transaction[1000];
    
    public TransactionList()
    {
        this.amountOfTransactions = 0;
    }
    
    public void Add(Transaction t)
    {
        Transactions[amountOfTransactions] = t;
        amountOfTransactions++;
    }
    
    public int GetLength()
    {
        return amountOfTransactions;
    }
    
    public Transaction GetTransaction(int i)
    {
        return Transactions[i - 1];
    }
}

class RepetitiveTransactionList : TransactionList
{
    protected int amountOfTransactions;
    
    protected RepetitiveTransaction[] RepetitiveTransactions =
        new RepetitiveTransaction[1000];
    
    public RepetitiveTransactionList()
    {
        this.amountOfTransactions = 0;
    }
    
    public void Add(RepetitiveTransaction t)
    {
        RepetitiveTransactions[amountOfTransactions] = t;
        amountOfTransactions++;
    }
    
    public int GetLength()
    {
        return amountOfTransactions;
    }
    
    public RepetitiveTransaction GetTransaction(int i)
    {
        return RepetitiveTransactions[i - 1];
    }
}

class HomeAccounting
{
    public static void Main()
    {
        string option = "";

        do
        {
            Console.WriteLine("TRANSACTIONS");
            Console.WriteLine("1- Add transaction");
            Console.WriteLine("2- Add repetitive transaction");
            Console.WriteLine("3- See transactions");
            Console.WriteLine("4- See repetitive transactions");
            Console.WriteLine("5- Search transaction");
            Console.WriteLine("Q- Quit");
            option = Console.ReadLine().ToUpper();

            switch (option)
            {
                case "1":
                    break;
                case "2":
                    break;
                case "3":
                    break;
                case "4":
                    break;
                case "5":
                    break;
                case "Q":
                    Console.WriteLine("Bye!");
                    break;
                default:
                    Console.WriteLine("Wrong option");
                    break;
            }
        } while (option != "Q");
    }
}
