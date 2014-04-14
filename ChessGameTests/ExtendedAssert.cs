using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ChessGameTests
{
    public static class ExtendedAssert
    {
        public static void Throws<TException>(Action executable) where TException : Exception
        {
            try
            {
                executable();
            }
            catch (Exception ex)
            {
                Assert.IsTrue(ex.GetType() == typeof(TException), string.Format("Expected exception of type {0} but got {1}", typeof(TException), ex.GetType()));
                return;
            }

            Assert.Fail(string.Format("Expected exception of type {0}, but no exception was thrown", typeof(TException)));
        }
    }
}
