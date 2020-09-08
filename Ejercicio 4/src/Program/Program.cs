using System;

namespace GameOfLife
{
    class Program
    {
        static void Main(string[] args)
        {
            FileParser fileParser = new FileParser();
            bool[,] gameArray = fileParser.ParseFile("./BoardFile.txt");

            GameBoard gameBoard = new GameBoard(gameArray);
        }
    }
}
