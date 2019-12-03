using System;
using System.IO;
using NUnit.Framework;

namespace Adventofcode2019.Tasks.Tests
{
    [TestFixture]
    public class IntCodeComputerTests
    {
        private IntCodeComputer c = null;

        public IntCodeComputerTests()
        {
            c = new IntCodeComputer();
        }

        [Test]
        public void IsCreated()
        {
            Assert.IsInstanceOf<IntCodeComputer>(c);
        }

        [Test]
        public void Computes()
        {
            Assert.AreEqual(new int[] { 2, 0, 0, 0, 99 }, c.Run(new int[] { 1, 0, 0, 0, 99 }));
        }

        [Test]
        public void Computes2()
        {
            Assert.AreEqual(new int[] { 2, 3, 0, 6, 99 }, c.Run(new int[] { 2, 3, 0, 3, 99 }));
        }

        [Test]
        public void Computes3()
        {
            Assert.AreEqual(new int[] { 2, 4, 4, 5, 99, 9801 }, c.Run(new int[] { 2, 4, 4, 5, 99, 0 }));
        }

        [Test]
        public void Computes4()
        {
            Assert.AreEqual(new int[] { 30, 1, 1, 4, 2, 5, 6, 0, 99 }, c.Run(new int[] { 1, 1, 1, 4, 99, 5, 6, 0, 99 }));
        }
    }
}
