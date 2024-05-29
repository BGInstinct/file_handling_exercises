using System;
using System.Linq;
using System.Collections.Generic;
using System.IO; // include the System.IO namespace for File class

class Program
{
    public static Dictionary<string, string> ImportingData(string filePath)
    {
        return File
          .ReadAllLines(filePath)
          .Select(x => x.Split('-'))
          .Where(x => x.Length > 1)
          .ToDictionary(x => x[0].Trim(), x => x[1]);
    }

    public static bool logInSuccessfully()
    {
        Console.WriteLine("Enter your username: ");
        string username = Console.ReadLine();
        Console.WriteLine("Enter your password: ");
        string password = Console.ReadLine();

        try
        {
            string filePath = $"users/{username}.txt";

            if (File.Exists(filePath))
            {
                var data = ImportingData(filePath);
                if (data["password"] == password)
                    return true;
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An error occurred: {ex.Message}");
        }
        return false;
    }

    public static bool singInSuccessfully()
    {
        Console.WriteLine("Enter your username: ");
        string username = Console.ReadLine();
        Console.WriteLine("Enter your password: ");
        string password = Console.ReadLine();
        string filePath = $"users/{username}.txt";
        if (File.Exists(filePath))
        {
            Console.WriteLine("File exists.");
            return false;
        }
        File.WriteAllText(filePath, $"username-{username}\npassword-{password}");
        return true;
    }

    public static void Main(string[] args)
    {
        Console.WriteLine("Program Started");
        Console.Write("Log In or Sing In (l/s): ");
        var logIn = Console.ReadLine();
        if (logIn == "l")
        {
            if (logInSuccessfully())
            {
                Console.WriteLine("Log In Successful");
            }
        }

        else if (logIn == "s")
        {
            if (singInSuccessfully())
            {
                Console.WriteLine("Sing In Successful");
            }
        }


    }
}