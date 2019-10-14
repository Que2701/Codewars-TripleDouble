using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TripleTroubleApp;

namespace TripleTroubleTest
{
    [TestClass]
    public class TripleTroubleTest
    {
        [TestMethod]
        public void TestTripleDouble()
        {
            // Arrange
            int expected = 1;

            // Act
            int actual = Program.TripleDouble(451999277, 41177722899);

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
