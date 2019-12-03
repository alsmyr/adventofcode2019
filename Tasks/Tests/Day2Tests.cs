using System;
using System.IO;
using NUnit.Framework;

namespace Adventofcode2019.Tasks.Tests
{
    [TestFixture]
    public class Day2Tests
    {
        private ITask d = null;

        public Day2Tests()
        {
            d = new Day2();
            d.Input = File.ReadAllLines(Directory.GetCurrentDirectory() + string.Format("/Input/Day{0}.txt", 2));
        }

        [Test]
        public void Day2Test1()
        {
            Assert.AreEqual("7210630", d.Run());
        }

        [Test]
        public void Day2Test2()
        {
            Assert.AreEqual("3892", d.Run2());
        }
    }
}
