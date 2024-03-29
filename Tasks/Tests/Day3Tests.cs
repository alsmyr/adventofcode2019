﻿using System;
using System.IO;
using NUnit.Framework;

namespace Adventofcode2019.Tasks.Tests
{
    [TestFixture]
    public class Day3Tests
    {
        private ITask d = null;

        public Day3Tests()
        {
            d = new Day3();
            d.Input = File.ReadAllLines(Directory.GetCurrentDirectory() + string.Format("/Input/Day{0}.txt", 3));
        }

        [Test]
        public void Day3Test1()
        {
            Assert.AreEqual("1674", d.Run());
        }
    }
}
