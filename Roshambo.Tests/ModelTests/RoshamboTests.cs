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
    public void IsPlayable_ValidInput()
    {
      //Arrange
      string invalidInput = "Stapler";
      Game game = new Game();
      //Act
      bool result = Game.InvalidGamePlayed(invalidInput);
      //Assert
      Assert.IsFalse(result);
    }
  }
}