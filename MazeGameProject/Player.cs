namespace MazeGameProject
{
    class Player : IMazeObject
    {
        public char Icon { get => '@'; }
        public bool IsSolid { get => true; }
        public int X { get; set; }
        public int Y { get; set; }

    }

}
