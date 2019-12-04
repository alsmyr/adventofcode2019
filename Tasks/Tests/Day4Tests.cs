using System;
using System.IO;
using NUnit.Framework;

namespace Adventofcode2019.Tasks.Tests
{
    [TestFixture]
    public class Day4Tests
    {
        private ITask d = null;

        public Day4Tests()
        {
            d = new Day4();
            d.Input = File.ReadAllLines(Directory.GetCurrentDirectory() + string.Format("/Input/Day{0}.txt", 4));
        }

        [Test]
        public void Day4Test7()
        {
            Assert.AreEqual("530", d.Run());
        }

        [Test]
        public void Day4Test1()
        {
            Day4 t = new Day4();
            Assert.IsTrue(t.Rule1(111111));
        }

        [Test]
        public void Day4Test2()
        {
            Day4 t = new Day4();
            Assert.IsTrue(t.Rule2(111111));
        }

        [Test]
        public void Day4Test3()
        {
            Day4 t = new Day4();
            Assert.IsTrue(t.Rule1(223450));
        }

        [Test]
        public void Day4Test4()
        {
            Day4 t = new Day4();
            Assert.IsFalse(t.Rule2(223450));
        }

        [Test]
        public void Day4Test5()
        {
            Day4 t = new Day4();
            Assert.IsFalse(t.Rule1(123789));
        }

        [Test]
        public void Day4Test6()
        {
            Day4 t = new Day4();
            Assert.IsTrue(t.Rule2(123789));
        }

        [Test]
        public void Day4Test8()
        {
            Day4 t = new Day4();
            Assert.IsTrue(t.Rule3(112233));
        }

        [Test]
        public void Day4Test9()
        {
            Day4 t = new Day4();
            Assert.IsFalse(t.Rule3(123444));
        }

        [Test]
        public void Day4Test10()
        {
            Day4 t = new Day4();
            Assert.IsTrue(t.Rule3(111122));
        }

        [Test]
        public void Day4Test11()
        {
            Assert.AreEqual("324", d.Run2());
        }
    }
}
