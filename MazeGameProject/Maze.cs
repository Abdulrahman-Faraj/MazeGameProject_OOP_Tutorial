using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MazeGameProject
{
    class Maze
    {
        private int _Height;
        private int _Wigth;
        private Player _Player;
        private IMazeObject[,] _MazeObjectsArray;

        public Maze(int wigth , int height)
        {
            _Wigth = wigth;
            _Height = height;
            _MazeObjectsArray = new IMazeObject[wigth, height];
            _Player = new Player()
            {
                X = 1,
                Y = 1
            };
            
        }
        public void DrawMaze()
        {
            Console.Clear();
            for (int y = 0; y < _Height; y++)
            {
                for (int x = 0; x < _Wigth; x++)
                {
                    //outer walls
                    if (x == 39 && y == 19)
                    {
                        _MazeObjectsArray[x, y] = new EmptySpace();
                        Console.Write(_MazeObjectsArray[x, y].Icon);
                    }
                    else if (x == 0 || y == 0 || x == _Wigth - 1 || y == _Height - 1)
                    {
                        _MazeObjectsArray[x, y] = new Wall();
                        Console.Write(_MazeObjectsArray[x, y].Icon);

                    }else if (x % 3 == 0 && y % 2 == 0)
                    {
                        _MazeObjectsArray[x, y] = new Wall();
                        Console.Write(_MazeObjectsArray[x, y].Icon);
                    }
                    else if (x == _Player.X && y == _Player.Y)
                    {
                        Console.Write(_Player.Icon);
                    }
                    else // empty spaces
                    {
                        _MazeObjectsArray[x, y] = new EmptySpace();
                        Console.Write(_MazeObjectsArray[x, y].Icon);
                    }
                }
                Console.WriteLine();
            }
        }
        public void MovePlayer()
        {
            var userinput =  Console.ReadKey();
            var Key = userinput.Key;
            switch(Key)
            {
                case ConsoleKey.UpArrow:
                    UpdatePlayer(0, -1);
                    break;
                case ConsoleKey.DownArrow:
                    UpdatePlayer(0, 1);
                    break;
                case ConsoleKey.LeftArrow:
                    UpdatePlayer(-1, 0);
                    break;
                case ConsoleKey.RightArrow:
                    UpdatePlayer(1, 0);
                    break;
                case ConsoleKey.End:
                    Environment.Exit(0);
                    break;
            }

        }
        private void UpdatePlayer(int dx , int dy)
        {
            int newY = _Player.Y + dy;
            int newX = _Player.X + dx;
            if (newX < _Wigth && newX >= 0 && newY < _Height && newY >= 0 && _MazeObjectsArray[newX , newY].IsSolid == false )
            {
                _Player.Y = newY;
                _Player.X = newX;
                DrawMaze();
            }
            
        }
    }
}
