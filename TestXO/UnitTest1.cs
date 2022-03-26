using System;
using Xunit;
using Lab04_TicTacToe;
using Lab04_TicTacToe.Classes;

namespace TestXO
{
    public class UnitTest1
    {
        static Player p1 = new Player
        {
            Name = "sultan",
            Marker = "X",
            IsTurn = true
        };

        static Player p2 = new Player
        {
            Name = "hussen",
            Marker = "O",
            IsTurn = false
        };

        Game newGame = new Game(p1, p2);

        // Given a game board, test for winners

        [Fact]
        public void TestWinners()
        {

            string[,] winBoard1 = new string[,]
            {
                {"1", "X", "3"},
                {"4", "X", "6"},
                {"7", "X", "9"},
            };

            newGame.Board.GameBoard = winBoard1;
            Assert.True(newGame.CheckForWinner(newGame.Board));
        }

        // Test that there is a switch in players between turns
        [Fact]
        public void TestPlayerSwitch()
        {
            newGame.SwitchPlayer();
            Assert.True(p2.IsTurn);
        }

        // Test to confirm that the position the player inputs correlates to the correct index of the array
        [Fact]
        public void TestPosition()
        {
            Position testPosition = new Position(0, 0);
            Assert.Equal(testPosition.Row, Player.PositionForNumber(1).Row);
        }

        [Fact]
        public void TestForFirstPlayerTurn()
        {
            Assert.True(p1.IsTurn);
        }

    }

}
