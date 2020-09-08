using System;
using System.IO;
using System.Collections;
using System.Threading;
using System.Text;

namespace GameOfLife
{
    public class Printer
    {
        public void ConsolePrint(Game game)
        {
            bool[,] b = game.Board.Board;
            int width = b.GetLength(0);
            int height = b.GetLength(1);
            while (true)
            {
                Console.Clear();
                StringBuilder s = new StringBuilder();
                for (int y = 0; y<height;y++)
                {
                    for (int x = 0; x<width; x++)
                    {
                        if(b[x,y])
                        {
                            s.Append("|X|");
                        }
                        else
                        {
                            s.Append("___");
                        }
                    }
                    s.Append("\n");
                }
                Console.WriteLine(s.ToString());
                game.ApplyLogic();
                Thread.Sleep(300);
            }
        }
    }
}