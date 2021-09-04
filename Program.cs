using System;

namespace Leet
{
    class Program
    {
        static void Main(string[] args)
        {
           Console.BackgroundColor = ConsoleColor.Red;
            Console.Write("Texto a ser traduzido: ");
             Console.BackgroundColor = ConsoleColor.Black;
              Console.ForegroundColor = ConsoleColor.Black;
               Console.BackgroundColor = ConsoleColor.Yellow;
           Console.WriteLine(
               Console.ReadLine()
          .Replace("T","7").Replace("t","7").Replace("a","4")
          .Replace("A","4").Replace("e","3").Replace("E","3")
          .Replace("S","5").Replace("s","5").Replace("I","1")
          .Replace("i","1").Replace("L","1").Replace("l","1")     
          );     
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
          










        }
    }
}
