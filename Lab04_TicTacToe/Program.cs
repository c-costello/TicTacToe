using System;
using Lab04_TicTacToe.Classes;

namespace Lab04_TicTacToe
{
    class Program
    {
        static void Main(string[] args)
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
                    game.Play();
                    break;

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
