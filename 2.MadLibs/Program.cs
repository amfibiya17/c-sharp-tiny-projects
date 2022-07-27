using System;

namespace MadLibs
{
  class Program
  {
    static void Main(string[] args)
    {
      // Let the user know that the program is starting:
      Console.WriteLine("This program will help you write a poem.\nHit enter to continue.");
      Console.ReadLine();

      // Mad Lib title
      Console.WriteLine("Enter the title of your poem: ");
      string title = Console.ReadLine();

      // Users input and variables
      Console.WriteLine("\nEnter a name: ");
      string name = Console.ReadLine();

      Console.WriteLine("\nEnter a feeling: ");
      string feeling = Console.ReadLine();

      Console.WriteLine("\nEnter an adjective: ");
      string adjective1 = Console.ReadLine();

      Console.WriteLine("\nEnter an animal: ");
      string animal = Console.ReadLine();

      Console.WriteLine("\nEnter a food: ");
      string food = Console.ReadLine();

      Console.WriteLine("\nEnter an action: ");
      string action = Console.ReadLine();

      Console.WriteLine("\nEnter a place: ");
      string place = Console.ReadLine();

      Console.WriteLine("\nEnter a fruit: ");
      string fruit = Console.ReadLine();

      Console.WriteLine("\nEnter another adjective: ");
      string adjective2 = Console.ReadLine();

      Console.WriteLine("\nEnter a superhero: ");
      string superhero = Console.ReadLine();

      Console.WriteLine("\nEnter a country: ");
      string country = Console.ReadLine();

      Console.WriteLine("\nEnter a dessert: ");
      string dessert = Console.ReadLine();

      Console.WriteLine("\nEnter a year: ");
      int year = Int32.Parse(Console.ReadLine());

      Console.WriteLine("\nEnter a noun: ");
      string noun = Console.ReadLine();

      // Template for the user's story
      Console.WriteLine("\nThis is your Poem:\n");
      string story = $"This morning {name} woke up feeling {feeling}. 'It is going to be a {adjective1} day!'\nOutside, a bunch of {animal}s were protesting to keep {food} in stores.\nThey began to {action} to the rhythm of the {place}, which made all the {fruit}s very {adjective2}.\nConcerned, {name} texted {superhero}, who flew {name} to the {country} and dropped {name} in a puddle of frozen {dessert}.\n{name} woke up in the year {year}, in a world where {noun}s ruled the world.";

      Console.WriteLine(title);
      Console.WriteLine(story);
    }
  }
}