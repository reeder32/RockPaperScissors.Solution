using System;
using Game.Models;
public class Program
{
  static void Main()
  {
    RockPaperScissors RPS = new RockPaperScissors();

    Console.WriteLine("Player 1 move: ");
    string moveChoice = Console.ReadLine();
    RPS.SetPlayerOneMove(moveChoice);

    Console.WriteLine("Player 2 move: ");
    moveChoice = Console.ReadLine();
    RPS.SetPlayerTwoMove(moveChoice);

    Console.WriteLine(RPS.GetWinner());
  }
}