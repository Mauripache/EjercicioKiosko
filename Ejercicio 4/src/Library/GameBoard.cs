using System;
using System.IO;
using System.Collections;

namespace GameOfLife
{
    /*
        Cumple SRP ya que se encarga solamente de conocer un board, si quisieramos cambiar el board por otro tipo
        de dato simplemente basta con venir a esta clase y cambiarlo.
    */
    public class GameBoard
    {
        public bool[,] Board{get;set;}
        public GameBoard(bool[,] gameBoard)
        {
            this.Board = gameBoard;
        }
    }
}
