using CodingChallenge.ReversingString;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace ChallengeUnitTest
{
    [TestFixture]
    public class ReversingStringUnitTest
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        [TestCase("BarBazQux", "xuQzaBraB")]
        [TestCase("Hello Foo", "ooF olleH")]
        [TestCase("This is an test", "tset na si sihT")]
        public void Reverse(string value, string reverse)
        {
            var result = StringUtilities.Reverse(value);
            Assert.AreEqual(reverse, result);
        }
    }
}
