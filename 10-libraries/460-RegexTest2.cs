// Adrián Navarro Gabino

using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;

class RegexTest2
{
    static bool IsAValidIdentifier(string s)
    {
        Regex r = new Regex(@"\A[A-Za-z][A-Za-z0-9]*\z");

        return r.IsMatch(s);
    }

    static void Main()
    {
        Dictionary<string, bool> test = new Dictionary<string, bool>();

        test.Add("2sfd", false);
        test.Add(" gfrg34f", false);
        test.Add("fdfg4", true);
        test.Add("jnjnjn", true);
        test.Add("324324", false);
        test.Add("fdg4g4", true);
        test.Add(";hfg4", false);
        test.Add(".gr5", false);

        foreach (KeyValuePair<string, bool> i in test)
        {
            string data = i.Key;
            bool expectedAnswer = i.Value;
            bool realAnswer = IsAValidIdentifier(data);

            if(realAnswer == expectedAnswer)
            {
                Console.WriteLine(data + " OK");
            }
            else
            {
                Console.WriteLine(data + " WRONG");
            }
        }
    }
}


