using System;
using System.IO;
using System.Collections;

namespace GameOfLife
{
    /*
        Conoce las reglas y recibe por parametro un board del tipo de objeto GameBoard
        solamente utiliza la propiedad del objeto y le aplica las reglas del juego.
        Solamente se encarga de conocer las reglas y aplicarlas cumple con SRP.
        Se podria colocar la logica dentro del objeto GameBoard ya que es el que conoce
        directamente el board, pero de esta manera el GameBoard puede ser cualquier cosa.
    */
    public class Game
    {
        public GameBoard Board{get;set;}
        public Game(GameBoard gameBoard)
        {
            this.Board = gameBoard;
        }

        public void ApplyLogic()
        {
            bool[,] gameBoard =  Board.Board;
            int boardWidth = gameBoard.GetLength(0);
            int boardHeight = gameBoard.GetLength(1);

            bool[,] cloneboard = new bool[boardWidth, boardHeight];
            for (int x = 0; x < boardWidth; x++)
            {
                for (int y = 0; y < boardHeight; y++)
                {
                    int aliveNeighbors = 0;
                    for (int i = x-1; i<=x+1;i++)
                    {
                        for (int j = y-1;j<=y+1;j++)
                        {
                            if(i>=0 && i<boardWidth && j>=0 && j < boardHeight && gameBoard[i,j])
                            {
                                aliveNeighbors++;
                            }
                        }
                    }
                    if(gameBoard[x,y])
                    {
                        aliveNeighbors--;
                    }
                    if (gameBoard[x,y] && aliveNeighbors < 2) 
                    {
                        //Celula muere por baja población
                        cloneboard[x,y] = false; 
                    }
                    else if (gameBoard[x,y] && aliveNeighbors > 3) 
                    {
                        //Celula muere por sobrepoblación
                        cloneboard[x,y] = false; 
                    }
                    else if (!gameBoard[x,y] && aliveNeighbors == 3) 
                    {
                        //Celula nace por reproducción 
                        cloneboard[x,y] = true; 
                    }
                    else
                    {
                        //Celula mantiene el estado que tenía
                        cloneboard[x,y] = gameBoard[x,y];
                    }
                }
            }

            gameBoard = cloneboard;
            cloneboard = new bool[boardWidth, boardHeight];
            this.Board = new GameBoard(gameBoard);
        }
    }
}
