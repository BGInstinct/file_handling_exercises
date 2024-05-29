using System;
using System.IO;
using System.Collections.Generic;

class Program
{
    public static void Main(string[] args)
    {
        string[] students = File.ReadAllLines("students.txt");
        foreach (string student in students)
        {
            Console.WriteLine(student);
        }
    }
}