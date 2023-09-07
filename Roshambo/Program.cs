using System;
using System.Collections.Generic;
using System.Linq;
using Roshambo.Models;


namespace Roshambo
{
  class Program
  {
    static void Main()
    {
      Console.WriteLine("Welcome to Ro Sham Bo!");
      Console.WriteLine("Player 1, Please select ROCK, PAPER or SCISSORS!");
      string player1Choice = Console.ReadLine();
      Console.WriteLine("Player 2, Please select ROCK, PAPER or SCISSORS!");
      string player2Choice = Console.ReadLine();
      var game = new Game();
      var winner = game.Play(player1Choice, player2Choice);
      Console.WriteLine(Play);

    }
  }
}