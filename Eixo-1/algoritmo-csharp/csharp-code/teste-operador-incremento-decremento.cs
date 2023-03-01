using System;

class MainClass {
  public static void Main (string[] args) {
    int preinc = 7, posinc = 7, predec = 7, posdec = 7;
    Console.WriteLine($"preinc = {++preinc}");
    Console.WriteLine($"posinc = {posinc++}");
    Console.WriteLine($"predec = {--predec}");
    Console.WriteLine($"posdec = {posdec--}");
    Console.WriteLine("\nREIMPRIMINDO");
    Console.WriteLine($"preinc = {preinc}");
    Console.WriteLine($"posinc = {posinc}");
    Console.WriteLine($"predec = {predec}");
    Console.WriteLine($"posdec = {posdec}");
  }
}