using System;
namespace Game.Models
{

  public class RockPaperScissors
  {

    private static string _playerOneMove { get; set; }

    private static string _playerTwoMove { get; set; }


    SetPlayerMoves(string moveString)
    {
      if (moveString.ToLower().CharAt(0) == "r")
      {
        return "rock";
      }
      else if (moveString.ToLower().CharAt(0) == "s")
      {
        return "scissors";
      }
      else if (moveString.ToLower().CharAt(0) == "p")
      {
        return "paper";
      }
      else
      {
        Console.WriteLine("Move string is incorrect format");
      }
    }
    public static SetPlayerOneMove(string move)
    {
      _playerOneMove = SetPlayerTwoMove(move);
    }
    public static SetPlayerTwoMove(string move)
    {
      _playerTwoMove = SetPlayerTwoMove(move);
    }

    public static string GetWinner()
    {
      if (_playerOneMove == _playerTwoMove)
      {
        return "Draw";
      }
      else if (_playerOneMove == "rock" && _playerTwoMove == "scissors")
      {
        return "Player One Wins";
      }
      else if (_playerOneMove == "paper" && _playerTwoMove == "rock")
      {
        return "Player One Wins";
      }
      else if (_playerOneMove == "scissors" && _playerTwoMove == "paper")
      {
        return "Player One Wins";
      }
      else
      {
        return "Player Two Wins";
      }
    }

    public static StartGameOverEvent(string move)
    {
      _playerOneMove = null;
      _playerTwoMove = null;
    }
  }
}