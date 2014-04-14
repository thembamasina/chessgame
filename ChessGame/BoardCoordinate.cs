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

        public bool IsCoordinateValidForBorderSize(int boardSize)
        {
            return IsDimensionValidForBoardSize(X, boardSize) && IsDimensionValidForBoardSize(Y, boardSize);
        }

        private static bool IsDimensionValidForBoardSize(int dimension, int boardSize)
        {
            return dimension > 0 && dimension <= boardSize;
        }
    }
}