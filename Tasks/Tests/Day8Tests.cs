using System;
using System.IO;
using NUnit.Framework;

namespace Adventofcode2019.Tasks.Tests
{
    [TestFixture]
    public class Day8Tests
    {
        private ITask d = null;

        public Day8Tests()
        {
            d = new Day8();
            d.Input = File.ReadAllLines(Directory.GetCurrentDirectory() + string.Format("/Input/Day{0}.txt", 8));
        }

        [Test]
        public void Day8Test1()
        {
            Assert.AreEqual("1064", d.Run());
        }
    }
}
