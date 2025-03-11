namespace MazeGameProject
{
    class Wall : IMazeObject
    {
        public char Icon { get => '#'; }
        public bool IsSolid { get => true; }
    }

}
