using System;
using System.IO;
using NUnit.Framework;

namespace Adventofcode2019.Tasks.Tests
{
    [TestFixture]
    public class Day1Tests
    {
        private ITask d = null;

        public Day1Tests()
        {
            d = new Day1();
            d.Input = File.ReadAllLines(Directory.GetCurrentDirectory() + string.Format("/Input/Day{0}.txt", 1));
        }

        [Test]
        public void Day1Test1()
        {
            Assert.AreEqual("3256599", d.Run());
        }

        [Test]
        public void Day1Test2()
        {
            Assert.AreEqual("4882038", d.Run2());
        }
    }
}
