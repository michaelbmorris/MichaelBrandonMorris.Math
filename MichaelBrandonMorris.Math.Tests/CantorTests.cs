using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MichaelBrandonMorris.Math.Tests
{
    /// <summary>
    ///     Class CantorTests.
    /// </summary>
    /// TODO Edit XML Comment Template for CantorTests
    [TestClass]
    public class CantorTests
    {
        /// <summary>
        ///     Determines whether this instance [can invert pair].
        /// </summary>
        /// TODO Edit XML Comment Template for CanInvertPair
        [TestMethod]
        public void CanInvertPair()
        {
            (int x, int y) = Cantor.Inverse(8);
            Assert.AreEqual(x, 1);
            Assert.AreEqual(y, 2);
        }

        /// <summary>
        ///     Determines whether this instance [can invert tuple].
        /// </summary>
        /// TODO Edit XML Comment Template for CanInvertTuple
        [TestMethod]
        public void CanInvertTuple()
        {
            var ints = Cantor.Inverse(69, 3);
            Assert.AreEqual(ints.Length, 3);
            Assert.AreEqual(ints[0], 1);
            Assert.AreEqual(ints[1], 2);
            Assert.AreEqual(ints[2], 3);
        }

        /// <summary>
        ///     Determines whether this instance can pair.
        /// </summary>
        /// TODO Edit XML Comment Template for CanPair
        [TestMethod]
        public void CanPair()
        {
            var z = Cantor.Pair(1, 2);
            Assert.AreEqual(z, 8);
        }

        /// <summary>
        ///     Determines whether this instance can tuple.
        /// </summary>
        /// TODO Edit XML Comment Template for CanTuple
        [TestMethod]
        public void CanTuple()
        {
            var z = Cantor.Tuple(1, 2, 3);
            Assert.AreEqual(z, 69);
        }
    }
}