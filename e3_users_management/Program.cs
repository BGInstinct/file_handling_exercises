using System;
using System.IO;

class Program
{
    public static void Main(string[] args)
    {
        string name = Console.ReadLine();
        string password = Console.ReadLine();
        string phone = Console.ReadLine();

        File.AppendAllText("user.txt", name + "\n" + password + "\n" + phone + "\n");

        // For c# 6 and above File.AppendAllText("user.txt", $"{name}\n{password}\n{phone}\n");
    }
}