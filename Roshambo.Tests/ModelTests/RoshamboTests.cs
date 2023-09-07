using Microsoft.VisualStudio.TestTools.UnitTesting;
using Roshambo.Models;
using System.Collections.Generic;
using System;

namespace Roshambo.Tests
{
  [TestClass]
  public class GameTests
  {
    [TestMethod]
    public void IsPlayable_InvalidInput()
    {
      //Arrange
      string invalidInput = "Stapler";
      Game game = new Game();
      //Act
      bool result = Game.ValidGamePlayed(invalidInput);
      //Assert
      Assert.IsFalse(result);
    }
    [TestMethod]
    public void IsPlayable_ValidInput()
    {
      //Arrange
      string validInput = "Rock";
      Game game = new Game();
      //Act
      bool result = Game.ValidGamePlayed(validInput);
      //Assert
      Assert.IsTrue(result);
    }
    [TestMethod]
    public void IsPlayable_TieGame()
    {
      //Arrange
      string tiedInput = "Rock";
      Game game = new Game();
      //Act
      bool result = Game.TiedRound(tiedInput);
      //Assert
      Assert.IsTrue(result);
    }
    [TestMethod]
    public void IsPlayable_OpposingGame()
    {
      //Arrange
      string playerInput = "Paper";
      Game game = new Game();
      //Act
      bool result = Game.BattleRound(playerInput);
      //Assert
      Assert.IsTrue(result);
    }
  }
}