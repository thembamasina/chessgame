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