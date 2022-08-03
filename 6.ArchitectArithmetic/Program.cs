using System;

namespace ArchitectArithmetic
{
  class Program
  {
    public static void Main(string[] args)
    {
      CalculateTotalCost();
    }

    static double Rect(double length, double width){
      return length * width;
    }

    static double Circle(double radius){
      return Math.PI * (Math.Pow(radius,2));
    }

    static double Triangle(double bottom, double height){
      return 0.5 * bottom * height;
    }

    static void CalculateTotalCost(){
      Console.WriteLine("What monument would you like to work with? \n");
      Console.Write("Choose Taj Mahal (1), Great Mosque Mecca (2), Teotihuacan (3): \n");
      string monument = Console.ReadLine();
      double totalArea;
      double totalCost;

      switch(monument){
        case "1":
        Console.WriteLine("\nTaj Mahal monument cost details\n");
        totalArea = Rect(90.5, 90.5) - 2 * Rect(24, 24);
        break;

        case "2":
        Console.WriteLine("\nGreat Mosque Mecca monument cost details\n");
        totalArea = Rect(180, 106) + Rect(200, 264) + Triangle(264, 84);
        break;

        case "3":
        Console.WriteLine("\nTeotihuacan monument cost details\n");
        totalArea = Rect(2500, 1500) + (Circle(375)/2) + Triangle(750, 500);
        break;

        default:
        totalArea = 0;
        break;
      }
      
      Console.WriteLine("Total Area: " + totalArea);
      totalCost = Math.Round((totalArea * 180), 2);
      Console.WriteLine($"My plan costs: {totalCost} pesos\n");
    }
  }
}
