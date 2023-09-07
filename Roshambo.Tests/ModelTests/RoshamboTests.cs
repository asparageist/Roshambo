using Microsoft.VisualStudio.TestTools.UnitTesting;
using Roshambo.Models;
using System.Collections.Generic;
using System;

namespace Roshambo.Tests
{
  [TestClass]
  public class Game
  {
    [TestMethod]
    public void RockPaperScissors_CorrectInput()
    {
      //Arrange
      Game game = new Game();
      //Act
      string played = game.InvalidGamePlayed();
      List<string> playerInput = new List<string> { "rock", "paper", "scissors" };
      //Assert
      foreach (var option in playerInput)
      {
        Assert.AreNotEqual(option, played);
      }
    }
  }
}