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
            Game game = new Game(p1, p2);

            game.Board.GameBoard = new string[,]
            {
                {"X", "X", "X"},
                {"X", "X", "X"},
                {"X", "X", "X"},
            };

            Assert.True(game.CheckForWinner(game.Board));

        }
        [Fact]
        public void WillReturnNoWinner()
        {
            Player p1 = new Player();
            Player p2 = new Player();
            Game gamee = new Game(p1, p2);

            gamee.Board.GameBoard = new string[,]
            {
                {"1", "2", "O"},
                {"4", "X", "6"},
                {"O", "8", "X"},
            };

            Assert.False(gamee.CheckForWinner(gamee.Board));

        }
        [Fact]
        public void WillSwitchToPlayerTwo()
        {
            Player p1 = new Player();
            Player p2 = new Player();
            Game game = new Game(p1, p2);
            game.PlayerOne.IsTurn = true;
            Assert.Equal(game.PlayerTwo, game.SwitchPlayer());

        }
        [Fact]
        public void WillSwitchToPlayerOne()
        {
            Player p1 = new Player();
            Player p2 = new Player();
            Game game = new Game(p1, p2);
            game.PlayerTwo.IsTurn = true;
            Assert.Equal(game.PlayerOne, game.SwitchPlayer());

        }

    }
}