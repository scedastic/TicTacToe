using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TicTacToe;

namespace TicTacToeTestProject
{
    [TestClass]
    public class BoardTest
    {
        [TestMethod]
        public void XWinsHorizontalTest()
        {

            char[,] testBoard = {
                { 'X', 'O', 'O'},
                { 'X', 'X', 'X'},
                { 'O', 'O', 'X'}
            };
            Assert.AreEqual(BoardStatus.XWins, Board.EvaluateBoard(testBoard));

            testBoard[1, 1] = 'O';
            testBoard[2, 0] = testBoard[2, 1] = testBoard[2, 2] = 'X';
            Assert.AreEqual(BoardStatus.XWins, Board.EvaluateBoard(testBoard));

            testBoard[2, 1] = 'O';
            testBoard[0, 1] = testBoard[0, 2] = 'X';
            Assert.AreEqual(BoardStatus.XWins, Board.EvaluateBoard(testBoard));
        }


        [TestMethod]
        public void XWinsVerticalTest()
        {
            char[,] testBoard = {
                { 'O', 'O', 'X'},
                { 'X', 'O', 'X'},
                { 'O', 'X', 'X'}
            };
            Assert.AreEqual(BoardStatus.XWins, Board.EvaluateBoard(testBoard));
            
            testBoard[1, 2] = 'O';
            testBoard[0, 1] = testBoard[1, 1] = testBoard[2, 1] = 'X';
            Assert.AreEqual(BoardStatus.XWins, Board.EvaluateBoard(testBoard));

            testBoard[1, 1] = 'O';
            testBoard[0, 0] = testBoard[1, 0] = testBoard[2, 0] = 'X';
            Assert.AreEqual(BoardStatus.XWins, Board.EvaluateBoard(testBoard));

        }


        [TestMethod]
        public void XWinsDiagonalTest()
        {
            char[,] testBoard = {
                { 'X', 'X', 'O'},
                { 'X', 'X', 'O'},
                { 'O', 'O', 'X'}
            };
            Assert.AreEqual(BoardStatus.XWins, Board.EvaluateBoard(testBoard));
                        
            testBoard[0, 0] = 'O';
            testBoard[0, 2] = testBoard[2, 0] = 'X';
            Assert.AreEqual(BoardStatus.XWins, Board.EvaluateBoard(testBoard));
        }

        [TestMethod]
        public void OWinsHorizontalTest()
        {

            char[,] testBoard = {
                { 'O', 'O', 'O'},
                { 'X', 'O', 'X'},
                { 'O', 'O', 'X'}
            };
            Assert.AreEqual(BoardStatus.OWins, Board.EvaluateBoard(testBoard));

            testBoard[0, 1] = 'X';
            testBoard[2, 0] = testBoard[2, 1] = testBoard[2, 2] = 'O';
            Assert.AreEqual(BoardStatus.OWins, Board.EvaluateBoard(testBoard));

            testBoard[2, 1] = 'E';
            testBoard[1, 0] = testBoard[1, 1] = testBoard[1, 2] = 'O';
            Assert.AreEqual(BoardStatus.OWins, Board.EvaluateBoard(testBoard));
        }
    
        [TestMethod]
        public void OWinsVerticalTest()
        {
            char[,] testBoard = {
                { 'O', 'O', 'O'},
                { 'X', 'O', 'X'},
                { 'O', 'O', 'X'}
            };
            Assert.AreEqual(BoardStatus.OWins, Board.EvaluateBoard(testBoard));

            testBoard[0, 1] = 'E';
            testBoard[0, 0] = testBoard[1, 0] = testBoard[2, 0] = 'O';
            Assert.AreEqual(BoardStatus.OWins, Board.EvaluateBoard(testBoard));

            testBoard[2, 0] = 'E';
            testBoard[0, 2] = testBoard[1, 2] = testBoard[2, 2] = 'O';
            Assert.AreEqual(BoardStatus.OWins, Board.EvaluateBoard(testBoard)); 
        }


        [TestMethod]
        public void OWinsDiagonalTest()
        {
            char[,] testBoard = {
                { 'O', 'X', 'O'},
                { 'X', 'O', 'X'},
                { 'O', 'O', 'X'}
            };
            Assert.AreEqual(BoardStatus.OWins, Board.EvaluateBoard(testBoard));

            testBoard[0, 2] = 'E';
            testBoard[2, 2] = 'O';
            Assert.AreEqual(BoardStatus.OWins, Board.EvaluateBoard(testBoard));
        }

        [TestMethod]
        public void DrawTest()
        {
            char[,] testBoard = {
                { 'O', 'X', 'O'},
                { 'X', 'O', 'X'},
                { 'X', 'O', 'X'}
            };
            Assert.AreEqual(BoardStatus.Draw, Board.EvaluateBoard(testBoard));
        }


        [TestMethod]
        public void InPlayTest()
        {
            char[,] testBoard = {
                { 'X', 'O', 'E'},
                { 'X', 'O', 'X'},
                { 'O', 'E', 'X'},
            };
            Assert.AreEqual(BoardStatus.InPlay, Board.EvaluateBoard(testBoard));
            testBoard[1, 1] = 'X';
            Assert.IsFalse(BoardStatus.InPlay == Board.EvaluateBoard(testBoard));
        }

        [TestMethod]
        public void CheckAllHorizontalTest()
        {
            char[,] testBoard = {
                { 'X', 'O', 'O'},
                { 'X', 'X', 'X'},
                { 'O', 'O', 'X'},
            };

            Assert.IsFalse(Board.CheckAllHorizontal(testBoard, 'O'));
            Assert.IsTrue(Board.CheckAllHorizontal(testBoard, 'X'));
            testBoard[1, 1] = 'O';
            testBoard[2, 0] = testBoard[2, 1] = testBoard[2, 2] = 'O';

            Assert.IsFalse(Board.CheckAllHorizontal(testBoard, 'X'));
            Assert.IsTrue(Board.CheckAllHorizontal(testBoard, 'O'));
        }

        [TestMethod]
        public void CheckAllVerticalTest()
        {
            char[,] testBoard = {
                { 'X', 'O', 'X'},
                { 'X', 'X', 'O'},
                { 'X', 'O', 'X'},
            };

            Assert.IsFalse(Board.CheckAllVertical(testBoard, 'O'));
            Assert.IsTrue(Board.CheckAllVertical(testBoard, 'X'));
            testBoard[1, 0] = testBoard[1, 1] = 'O';
            Assert.IsFalse(Board.CheckAllVertical(testBoard, 'X'));
            Assert.IsTrue(Board.CheckAllVertical(testBoard, 'O'));
        }

        [TestMethod]
        public void CheckAllDiagonalTest()
        {
            char[,] testBoard = {
                { 'X', 'O', 'O'},
                { 'E', 'X', 'O'},
                { 'E', 'O', 'X'},
            };
            Assert.IsTrue(Board.CheckAllDiagonal(testBoard, 'X'));
            Assert.IsFalse(Board.CheckAllDiagonal(testBoard, 'O'));

            testBoard[0, 0] = 'O';
            testBoard[0, 2] = testBoard[2, 0] = 'X';
            Assert.IsTrue(Board.CheckAllDiagonal(testBoard, 'X'));
            Assert.IsFalse(Board.CheckAllDiagonal(testBoard, 'O'));

            testBoard[0, 0] = testBoard[1, 1] = testBoard[2, 2] = 'O';
            Assert.IsTrue(Board.CheckAllDiagonal(testBoard, 'O'));
            Assert.IsFalse(Board.CheckAllDiagonal(testBoard, 'X'));


            testBoard[0, 0] = 'X';
            testBoard[0, 2] = testBoard[2, 0] = 'O';
            Assert.IsTrue(Board.CheckAllDiagonal(testBoard, 'O'));
            Assert.IsFalse(Board.CheckAllDiagonal(testBoard, 'X'));

        }

        [TestMethod]
        public void HasAnyTest()
        {
            char[,] testBoard = {
                { 'X', 'O', 'O'},
                { 'E', 'X', 'O'},
                { 'E', 'O', 'X'},
            };
            Assert.IsTrue(Board.HasAny(testBoard, 'E'));
            Assert.IsTrue(Board.HasAny(testBoard, 'O'));
            Assert.IsTrue(Board.HasAny(testBoard, 'X'));
            Assert.IsFalse(Board.HasAny(testBoard, 'A'));
            Assert.IsFalse(Board.HasAny(testBoard, '5'));
        }

    }
}
