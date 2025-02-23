using System;

namespace DIO
{
  class DividindoXPorY 
  {    
    static void Main(string[] args) 
    {
      int limit = Int32.Parse(Console.ReadLine());
          
      for (int i = 0; i < limit; i++) {
        string[] line = Console.ReadLine().Split(" ");
          
        double X = double.Parse(line[0]);
        double Y = double.Parse(line[1]);
          
        if (Y == 0) {
          Console.WriteLine("divisao impossivel");
        } else {
          double divisao = (double) X / Y;
        
          if (divisao < 0 && divisao > -0.5) {
            Console.WriteLine("-0.0");
          } else {
            Console.WriteLine(Math.Round(divisao, 1).ToString("N1"));
          }
        }
      }
    }
  }
}