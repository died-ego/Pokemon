using System;

namespace Pokemon
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.Clear();
      var pokemonPicker = CreateRandomNumber();
      string pokemon = "";
      if ((pokemonPicker >= 1) && (pokemonPicker < 35))
      {
        pokemon = "Ratata";
      }
      else if ((pokemonPicker >= 36) && (pokemonPicker < 60))
      {
        pokemon = "Pidgey";
      }
      else if ((pokemonPicker >= 60) && (pokemonPicker < 75))
      {
        pokemon = "Sentret";
      }
      else if ((pokemonPicker >= 75) && (pokemonPicker < 85))
      {
        pokemon = "Oddish";
      }
      else if ((pokemonPicker >= 85) && (pokemonPicker < 95))
      {
        pokemon = "Belsprout";
      }
      else if ((pokemonPicker >= 95) && (pokemonPicker <= 100))
      {
        pokemon = "Furret";
      }
      ChooseRandomSkill(4);
    }
    private static int CreateRandomNumber()
    {
      Random random = new Random();
      int randomNumber = random.Next(1, 100);
      return randomNumber;
    }

    private static void ChooseRandomSkill(int skillsAmount)
    {
      string skills = "Tackle;Growl;Vine Whip;Growth;Leech Seed;Razor Leaf;Poison Powder;Sleep Powder;Seed Bomb;Take Down;Sweet Scent;Synthesis;Worry Seed;Double-Edge;Solar Beam";
      string[] skillsArray = skills.Split(";");
      for (int i = 0; i < skillsAmount; i++)
      {
        Random random = new Random();
        int randomNumber = random.Next(0, skillsArray.Length);
        for (int k = 0; k <= skillsArray.Length; k++)
        {
          if (k == randomNumber)
          {
            Console.WriteLine(skillsArray[k]);
          }
        }
      }
    }
  }
}