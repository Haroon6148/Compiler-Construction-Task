using System;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        string pattern = @"^(?=.*[A-Z])(?=(.*[\W_]){2,})(?=.*06)(?=(.*[haroonshoaib]){4,})[A-Za-z0-9\W_]{8,12}$";
        string[] testPasswords = {
            "06Ha@ron#",
            "Sho06@iB!",
            "HarOon06$#",
            "06Aa@bS_ho"
        };

        foreach (string password in testPasswords)
        {
            Console.WriteLine($"{password}: {Regex.IsMatch(password, pattern)}");
        }
    }
}
