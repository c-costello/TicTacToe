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
            game.SwitchPlayer();
            Assert.Equal(game.PlayerTwo, game.NextPlayer());

        }
        [Fact]
        public void WillSwitchToPlayerOne()
        {
            Player p1 = new Player();
            Player p2 = new Player();
            Game game = new Game(p1, p2);
            game.PlayerTwo.IsTurn = true;
            game.SwitchPlayer();
            Assert.Equal(game.PlayerOne, game.NextPlayer());

        }

        [Fact]
        public void WillConvertNumbersToPositionRow()
        {
            Player p1 = new Player();
            Player p2 = new Player();
            Game game = new Game(p1, p2);

            Position assumed = new Position(0,0);

            Assert.Equal(assumed.Row, Player.PositionForNumber(1).Row);
        }
        [Fact]
        public void WillConvertNumbersToPositionColumn()
        {
            Player p1 = new Player();
            Player p2 = new Player();
            Game game = new Game(p1, p2);

            Position assumed = new Position(0, 0);

            Assert.Equal(assumed.Column, Player.PositionForNumber(1).Column);
        }
        [Fact]
        static void WillReturnGameBoard()
        {
            Player p1 = new Player();
            Player p2 = new Player();
            Game game = new Game(p1, p2);
            string[,] expectedReturn = new string[,]
            {
                {"1", "2", "3"},
                {"4", "5", "6"},
                {"7", "8", "9"},
            };
            Assert.Equal(expectedReturn, game.Board.GameBoard);
        }

    }
}