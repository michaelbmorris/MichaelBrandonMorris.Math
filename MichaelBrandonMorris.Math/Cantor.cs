using System;
using MichaelBrandonMorris.Extensions.CollectionExtensions;

namespace MichaelBrandonMorris.Math
{
    /// <summary>
    ///     Class Cantor.
    /// </summary>
    /// TODO Edit XML Comment Template for Cantor
    public static class Cantor
    {
        /// <summary>
        ///     Inverses the specified z.
        /// </summary>
        /// <param name="z">The z.</param>
        /// <returns>System.Int32.</returns>
        /// TODO Edit XML Comment Template for Inverse
        public static (int x, int y) Inverse(int z)
        {
            var w = (int) System.Math.Floor(
                (System.Math.Sqrt(8 * z + 1) - 1) / 2);
            var t = (w * w + w) / 2;
            var y = z - t;
            var x = w - y;
            return (x, y);
        }

        /// <summary>
        ///     Inverses the specified z.
        /// </summary>
        /// <param name="z">The z.</param>
        /// <param name="n">The n.</param>
        /// <returns>System.Int32[].</returns>
        /// <exception cref="ArgumentException">
        ///     Cantor inverse function
        ///     requires n to be at least two.
        /// </exception>
        /// TODO Edit XML Comment Template for Inverse
        public static int[] Inverse(int z, int n)
        {
            if (n < 2)
            {
                throw new ArgumentException(
                    "Cantor inverse function requires n to be at least two.");
            }

            return Inverse(z, n, new int[n]);
        }

        /// <summary>
        ///     Pairs the specified x.
        /// </summary>
        /// <param name="x">The x.</param>
        /// <param name="y">The y.</param>
        /// <returns>System.Int32.</returns>
        /// TODO Edit XML Comment Template for Pair
        public static int Pair(int x, int y)
        {
            return (x + y) * (x + y + 1) / 2 + y;
        }

        /// <summary>
        ///     Tuples the specified ints.
        /// </summary>
        /// <param name="ints">The ints.</param>
        /// <returns>System.Int32.</returns>
        /// <exception cref="ArgumentException">
        ///     Cantor tuple function
        ///     requires at least two arguments.
        /// </exception>
        /// TODO Edit XML Comment Template for Tuple
        public static int Tuple(params int[] ints)
        {
            if (ints.Length < 2)
            {
                throw new ArgumentException(
                    "Cantor tuple function requires at least two arguments.");
            }

            return Tuple(ints[0], ints[1], ints.Skip(2));
        }

        /// <summary>
        ///     Inverses the specified z.
        /// </summary>
        /// <param name="z">The z.</param>
        /// <param name="n">The n.</param>
        /// <param name="ints">The ints.</param>
        /// <returns>System.Int32[].</returns>
        /// TODO Edit XML Comment Template for Inverse
        private static int[] Inverse(int z, int n, int[] ints)
        {
            while (true)
            {
                (int x, int y) = Inverse(z);

                if (n == 2)
                {
                    ints[0] = x;
                    ints[1] = y;

                    return ints;
                }

                n--;
                ints[n] = y;
                z = x;
            }
        }

        /// <summary>
        ///     Tuples the specified x.
        /// </summary>
        /// <param name="x">The x.</param>
        /// <param name="y">The y.</param>
        /// <param name="ints">The ints.</param>
        /// <returns>System.Int32.</returns>
        /// TODO Edit XML Comment Template for Tuple
        private static int Tuple(int x, int y, int[] ints)
        {
            while (true)
            {
                var pair = Pair(x, y);

                if (ints.Length == 0)
                {
                    return pair;
                }

                x = pair;
                y = ints[0];
                ints = ints.Skip(1);
            }
        }
    }
}