namespace MazeGameProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Maze maze = new Maze(40, 20); //new maze
            while (true)
            {
                maze.DrawMaze();
                maze.MovePlayer();
            
            }
        }
    }
}
/*
 * Player // move // maze // arrow keys // exit // displayed // walls //empty spaces // layout // character // position 
 * 
 * Imazeobject => interface 
 * يمكن تكون wall - empty space - player - 
 * 
 * Maze class = height * wight * draw function * move function  * 
 * 
 */