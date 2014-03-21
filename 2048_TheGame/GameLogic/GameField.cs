using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _2048_TheGame.GameLogic
{

    public enum Turns { Up, Right, Down, Left }
    public class Cell
    {
        public int Value { get; set; }
        
        public Cell()
        {
            Value = 2;
        }

        public void MergeCell()
        {
            Value = Value*2;
        }
    }
    class GameField
    {
        public Cell[][] Cells;
        public const int FieldSize = 4;
        public Dictionary<int, Cell> Field;
        private Random Rand;

        public GameField()
        {
            Cells = new Cell[FieldSize][];
            for(int i = 0; i < FieldSize; i++)
            {
                Cells[i] = new Cell[FieldSize];
            }

            Rand = new Random((int)(DateTime.Now.Ticks % 182741696739112));

        }

        public void GenerateNewRandomField()
        {
            int randomPosition;
            while (true)
            {
                randomPosition = Rand.Next()%16;
                int x = randomPosition/4;
                int y = randomPosition%4;

                if (Cells[x][y] != null){
                    Cells[x][y] = new Cell();
                    break;
                }
        }
    }
    }
}
