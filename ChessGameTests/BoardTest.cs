using System;
using ChessGame;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ChessGameTests
{
    [TestClass]
    public class BoardTest
    {
        private Pawn Piece { get; set; }
        private Board Target { get; set; }

        [TestInitialize]
        public void BeforeEachTest()
        {
            Piece = new Pawn();
            Target = new Board();
        }

        [TestClass]
        public class GetPiece : BoardTest
        {
            [TestMethod, Owner("Themba"), TestCategory("Proven"), TestCategory("Unit")]
            public void Retrieves_Piece_Added_To_Location()
            {
                Target.AddPiece(Piece, new BoardCoordinate(1, 1));
                Assert.AreEqual(Piece, Target.GetPiece(1,1));
            }
        }

        [TestClass]
        public class AddPiece : BoardTest
        {
            [TestMethod, Owner("Themba"), TestCategory("Proven"), TestCategory("Unit")]
            public void Does_Not_Throw_Exception_When_Adding_A_Piece_To_An_Unoccupied_Square()
            {
                Target.AddPiece(Piece, new BoardCoordinate(2, 1));
            }
        }
    }
}

