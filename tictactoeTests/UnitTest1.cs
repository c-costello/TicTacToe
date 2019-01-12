using System;
using Xunit;
using Lab04_TicTacToe;
using Lab04_TicTacToe.Classes;

namespace tictactoeTests
{
    public class UnitTest1
    {
        [Fact]
        public void WillReturnWinner()
        {
            Player p1 = new Player();
            Player p2 = new Player();
            Game gamee = new Game(p1, p2);

            gamee.Board.GameBoard = new string[,]
            {
                {"X", "X", "X"},
                {"X", "X", "X"},
                {"X", "X", "X"},
            };

            Assert.True(gamee.CheckForWinner(gamee.Board));

        }
    }
}