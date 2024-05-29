using System;
using System.IO;

class Program {
  public static void Main (string[] args) {
    string name = Console.ReadLine();
    File.Create(name);
  }
}