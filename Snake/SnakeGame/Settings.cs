using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake_Game
{
    //set the snake directions
    public enum Direction
    {
        Up,
        Down,
        Left,
        Right
    };

    public class settings
    {
        //game settings
        public static int Width { get; set; }
        public static int Height { get; set; }
        public static int Speed { get; set; }
        public static int Score { get; set; }
        public static int Points { get; set; }
        public static bool GameOver { get; set; }
        public static Direction direction { get; set; }

        public settings()
        {
            Width = 10;
            Height = 10;
            Speed = 10;
            Score = 0;
            Points = 10;
            GameOver = false;
            direction = Direction.Down;
        }
    }
}
