# TicTacToe
TicTacToe Board Evaluator

## Project: TicTacToe
### Board.cs
- Static class that evaluates a TicTacToe board.
- `public static BoardStatus EvaluateBoard(char[,] gameBoard)`
  - gameBoard is a 3 x 3 array in which each 'cell' should either be 'X', 'O' or 'E' for empty.
  
### BoardStatus.cs
- enum that defines the 4 possible outcomes of EvaluateBoard

## Project: TicTacToeTestProject
### BoardTest.cs
- Listing of the most common scenarios of a TicTacToe board to test.
