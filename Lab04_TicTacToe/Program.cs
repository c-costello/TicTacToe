using System;
using Lab04_TicTacToe.Classes;

namespace Lab04_TicTacToe
{
    public class Program
    {
        /// <summary>
        /// Runs a switch statement to start game or exit
        /// sets up players, instantiates game board, calls game.Play();
        /// </summary>
        /// <param name="args"></param>
        public static void Main(string[] args)
        { 
            Start:
                Console.WriteLine("Would you like to play a game?");
            Console.WriteLine("1. Yes");
            Console.WriteLine("2. No");
            string responseStr = Console.ReadLine();

            switch (responseStr)
            {
                case "1":
                    Player p1 = new Player();
                    Player p2 = new Player();
                    Game game = new Game(p1, p2);
                    Player winner = game.Play();
                    if (winner != null)
                    {
                        Console.WriteLine($"{winner.Name} wins!");
                    }
                    goto Start;
                    

                case "2":
                    Environment.Exit(0);
                    break;

                default:
                    Console.Clear();
                    goto Start;
            }
        }        
    }
}
