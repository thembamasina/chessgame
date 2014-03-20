using System;
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
            public void Returns_2_3_When_Passed_2_2()
            {
                var pawn = new Pawn();

                Tuple<int, int> possibleMoves = pawn.GetMovesFrom(2, 2);
                Assert.AreEqual(2, possibleMoves.Item1);
                Assert.AreEqual(3, possibleMoves.Item2);
            }
        }
    }
}