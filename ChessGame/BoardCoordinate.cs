namespace ChessGame
{
    public struct BoardCoordinate
    {
        private readonly int _x;
        private readonly int _y;

        public BoardCoordinate(int x, int y)
        {
            _x = x;
            _y = y;
        }

        public int X
        {
            get { return _x; }
        }

        public int Y
        {
            get { return _y; }
        }
    }
}