using System;
using System.Collections.Generic;

namespace PetApp
{
  class Program
  {
    static void Main(string[] args)
    {
      var shelter = new List<string>();

      var isRunning = true;
      while (isRunning)
      {
        Console.WriteLine("Current Pets");
        Console.WriteLine($"There are {shelter.Count} pets.");
        for (var i = 0; i < shelter.Count; i++)
        {
          var currentPet = shelter[i];
          Console.WriteLine($"{i}:{currentPet}");
        }

        //small menu system
        Console.WriteLine("What do you want to do?");
        Console.WriteLine("(ADD) a pet?");
        Console.WriteLine("(ADOPT) a pet");
        Console.WriteLine("(QUIT)");
        var input = Console.ReadLine();

        if (input.ToLower() == "add")
        {
          Console.WriteLine("What pet would you like to add?");
          var pet = Console.ReadLine();
          shelter.Add(pet);
        }
        else if (input.ToLower() == "adopt")
        {
          //Delete ... Remove
          Console.WriteLine("What is the number of the pet that is getting adopted?");
          var pet = Console.ReadLine();
          shelter.RemoveAt(int.Parse(pet));
        }
        else if (input.ToLower() == "quit")
        {
          isRunning = false;
        }

      }

      Console.WriteLine("Goodbye");
    }
  }
}
