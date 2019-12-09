using System;
using System.IO;
using NUnit.Framework;

namespace Adventofcode2019.Tasks.Tests
{
    [TestFixture]
    public class Day6Tests
    {
        private ITask d = null;

        public Day6Tests()
        {
            d = new Day6();
            d.Input = File.ReadAllLines(Directory.GetCurrentDirectory() + string.Format("/Input/Day{0}.txt", 6));
        }

        [Test]
        public void Day6Test1()
        {
            Assert.AreEqual("253104", d.Run());
        }

        [Test]
        public void Day6Test2()
        { 
            Assert.AreEqual("499", d.Run2());
        }
    }
}
