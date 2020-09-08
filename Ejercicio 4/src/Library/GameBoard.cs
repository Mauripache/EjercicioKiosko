using System;
using System.IO;
using System.Collections;

namespace GameOfLife
{
    public class GameBoard
    {
        public bool[,] Board{get;set;}
        public GameBoard(bool[,] gameBoard)
        {
            this.Board = gameBoard;
        }
    }
}
