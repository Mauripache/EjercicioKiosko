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
            Game newGame = new Game(gameBoard);
            Printer printer = new Printer();
            while (true)
            {  
                printer.ConsolePrint(newGame);
            }
        }
    }
}
