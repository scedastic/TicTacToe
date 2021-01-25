using System;
using System.Collections.Generic;
using System.Text;

namespace TicTacToe
{
    public class Board
    {
        public char[,] GameBoard { get; }

        public static BoardStatus EvaluateBoard(char[,] gameBoard)
        {
            if (
                CheckAllHorizontal(gameBoard, 'X') ||
                CheckAllVertical(gameBoard, 'X') ||
                CheckAllDiagonal(gameBoard, 'X')
                )
            {
                return BoardStatus.XWins;
            }
            else if (CheckAllHorizontal(gameBoard, 'O') ||
                CheckAllVertical(gameBoard, 'O') ||
                CheckAllDiagonal(gameBoard, 'O')
                )
            {
                return BoardStatus.OWins;
            }
            else if (!HasAny(gameBoard, 'E'))
                return BoardStatus.Draw;
            else
                return BoardStatus.InPlay;
        }

        public static bool HasAny(char[,] gameBoard, char token)
        {
            foreach(char c in gameBoard)
            {
                if (c.Equals(token))
                    return true;

            }
            return false;
        }

        public static bool CheckAllHorizontal(char[,] gameBoard, char token)
        {
            for (int i = 0; i < 3; i++)
                if (token == gameBoard[i, 0] &&
                    token == gameBoard[i, 1] &&
                    token == gameBoard[i, 2])
                    return true;
            return false;
        }
        public static bool CheckAllVertical(char[,] gameBoard, char token)
        {
            for (int i = 0; i < 3; i++)
                if (token == gameBoard[0, i] &&
                    token == gameBoard[1, i] &&
                    token == gameBoard[2, i])
                    return true;
            return false;
        }
        public static bool CheckAllDiagonal(char[,] gameBoard, char token)
        {
            if (
                (token == gameBoard[0, 0] &&
                token == gameBoard[1, 1] &&
                token == gameBoard[2, 2]) ||
                (token == gameBoard[0, 2] &&
                token == gameBoard[1, 1] &&
                token == gameBoard[2, 0])
               )
                return true;
            return false;


        }
    }
}
