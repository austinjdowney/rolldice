using System;
using rolldice.Models;

namespace rolldice
{
  class Program
  {
    static void Main(string[] args)
    {
      Dice d6 = new Dice(6);
      bool running = true;
      while (running)
      {
        Console.WriteLine("Press any Key to ROll");
        Console.ReadKey();
        int total = 0;
        for (int i = 0; i < 3; i++)
        {
          int first = d6.Roll();
          int second = d6.Roll();
          Console.WriteLine(first + " : " + second);
          if (first == second)
          {
            total = 0;
            break;
          }
          total += first + second;
        }

        Console.WriteLine($"Your Score is: {total}");
      }
    }
  }
}
