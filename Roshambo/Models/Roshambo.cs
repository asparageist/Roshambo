using System.Collections.Generic;
using System;

namespace Roshambo.Models
{
  public class Game
  {
    public static bool ValidGamePlayed(string input)
    {
      string inputWord = input;
      string normalizedInput = inputWord.ToLower();

      if (normalizedInput == "rock" || normalizedInput == "paper" || normalizedInput == "scissors")
      {
        return true;
      }
      return false;
    }

    public static bool TiedRound(string input)
    {
      string inputWord = input;
      string normalizedInput = inputWord.ToLower();
      string tiedInput = inputWord.ToLower();

      if (normalizedInput == tiedInput)
      {
        return true;
      }
      return false;
    }
    public static bool BattleRound(string input)
    {
      string inputWord = input;
      string normalizedInput = inputWord.ToLower();
      string opposingInput = "Rock";

      if (normalizedInput != opposingInput && normalizedInput == "paper")
      {
        return true;
      }
      return false;
    }
    //Possible game play
    public enum Choice
    {
      Rock, Paper, Scissors
    }
    public static string Play(Choice player1Choice, Choice player2Choice)
    {
      if (player1Choice == player2Choice)
      {
        return "Draw";
      }

      if ((player1Choice == Choice.Rock && player2Choice == Choice.Scissors) ||
        (player1Choice == Choice.Paper && player2Choice == Choice.Rock) ||
        (player1Choice == Choice.Scissors && player2Choice == Choice.Paper))
      {
        return "Player 1";
      }
      return "Player 2";
    }
  }

}



