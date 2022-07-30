using System;

namespace MoneyMaker
{
  class MainClass
  {
    public static void Main(string[] args)
    {   
      Console.WriteLine("Welcome to Money Maker!");  
      Console.WriteLine("Enter an amount you'd like to convert to coins: ");
      
      string totalAsString = Console.ReadLine();
      Console.WriteLine(totalAsString);
      
      double total = Convert.ToDouble(totalAsString);
      Console.WriteLine($"{total} cents is equal too..");
      
      int goldValue = 10;
      int silverValue = 5;
      
      double goldCoins = Math.Floor(total  / goldValue);
      double remainder = total % goldValue;
      double silverCoins = Math.Floor(remainder / silverValue);
      remainder = remainder % silverValue;
      
      Console.WriteLine($"Gold coins: {goldCoins}");
      Console.WriteLine($"Silver coins: {silverCoins}");
      Console.WriteLine($"Bronze coins: {remainder}");      
    }
  }
}