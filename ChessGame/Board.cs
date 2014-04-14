using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessGame
{
    public class Board
    {
        private const int BoardSize = 8;
        private readonly Pawn[,] _pieces = new Pawn[BoardSize, BoardSize];
        public void AddPiece(Pawn piece, BoardCoordinate moveTarget)
        {
            if (!moveTarget.IsCoordinateValidForBorderSize(BoardSize))
                throw new ArgumentException("moveTarget");
            
            _pieces[moveTarget.X, moveTarget.Y] = piece;
        }

        public Pawn GetPiece(BoardCoordinate squareInQuestion)
        {
            return _pieces[squareInQuestion.X,squareInQuestion.Y];
        }
    }
}
