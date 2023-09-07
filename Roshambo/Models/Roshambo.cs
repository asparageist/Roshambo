using System.Collections.Generic;
using System;

namespace Roshambo.Models
{
  public class Game
  {
    public static bool InvalidGamePlayed(string input)
    {
      string inputWord = "stapler";
      string normalizedInput = inputWord.ToLower();

      if (normalizedInput == "rock" || normalizedInput == "paper" || normalizedInput == "scissors")
      {
        return true;
      }
      return false;
    }
  }
}
