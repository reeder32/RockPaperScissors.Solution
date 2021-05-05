using System;
namespace Game.Models
{

  public class RockPaperScissors
  {

    private string _playerOneMove { get; set; }

    private string _playerTwoMove { get; set; }

    public RockPaperScissors()
    {

    }
    private string SetPlayerMoves(string moveString)
    {
      if (moveString.ToLower()[0] == 'r')
      {
        return "rock";
      }
      else if (moveString.ToLower()[0] == 's')
      {
        return "scissors";
      }
      else if (moveString.ToLower()[0] == 'p')
      {
        return "paper";
      }
      else
      {
        return "Move string is incorrect format";
      }
    }
    public void SetPlayerOneMove(string move)
    {
      _playerOneMove = SetPlayerMoves(move);
    }
    public void SetPlayerTwoMove(string move)
    {
      _playerTwoMove = SetPlayerMoves(move);
    }

    public string GetWinner()
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

    public void StartGameOverEvent()
    {
      _playerOneMove = null;
      _playerTwoMove = null;
    }
  }
}