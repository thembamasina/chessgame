using System;
using System.Linq;
using ChessGame;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ChessGameTests
{
    [TestClass]
    public class PawnTest
    {
        [TestClass]
        public class GetMovesFrom
        {
            [TestMethod, Owner("Themba"), TestCategory("Proven"), TestCategory("Unit")]
            public void Returns_2_3_As_One_Reulst_When_Passed_2_2()
            {
                var pawn = new Pawn();
                var possibleMoves = pawn.GetMovesFrom(2, 2);
                Assert.IsTrue(possibleMoves.Any(x=>x.X == 2 && x.Y == 3));
            }
        }
    }
}


[TestClass]
public class BoardCoordinateTest
{
    [TestClass]
    public class IsCooIsCoordinateValidForBorderSize
    {
        [TestMethod, Owner("Themba"), TestCategory("Proven"), TestCategory("Unit")]
        public void Returns_Falss_For_X_Less_Than_Zero()
        {
            var coordinate = new BoardCoordinate(-12, 2);
            Assert.IsFalse(coordinate.IsCoordinateValidForBorderSize(5));
        }
        
        [TestMethod, Owner("Themba"), TestCategory("Proven"), TestCategory("Unit")]
        public void Returns_Falss_For_Y_Less_Than_Zero()
        {
            var coordinate = new BoardCoordinate(1, -23);
            Assert.IsFalse(coordinate.IsCoordinateValidForBorderSize(8));
        }
    }    
}