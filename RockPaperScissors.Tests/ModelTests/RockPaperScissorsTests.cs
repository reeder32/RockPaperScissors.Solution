using Microsoft.VisualStudio.TestTools.UnitTesting;
using Game.Models;

namespace Game.Tests
{
  [TestClass]
  public class RockPaperScissorsTests
  {

    [TestMethod]
    // how to handle incorrect string (Not R, P, or S)
    public void InputShouldBeInCorrectLetterOrString_True()
    {
      string type = "Rock";

      RockPaperScissors RPS = new RockPaperScissors(type);

      Assert.AreEqual(type, RockPaperScissors.GetDescription());
    }
  }
}


// how to handle non string input

// order of operations for 2 players is correct

// All possible inputs:
// P1: Rock, P2: Rock
// P1: Rock, P2: Paper
// P1: Rock, P2: Scissors
// P1: Paper, P2: Rock
// P1: Paper, P2: Paper
// P1: Paper, P2: Scissors
// P1: Scissors, P2: Rock
// P1: Scissors, P2: Paper
// P1: Scissors, P2: Scissors

// All possible outputs:
// P1 win
// P2 win
// Draw

// return correct winner
// return draw
