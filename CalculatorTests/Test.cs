using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using NUnit.Framework;
using System;

namespace TestSample
{
    public class Tests
    {
        private Calculator calc;
        [SetUp]
        public void Setup()
        {
            calc = new Calculator();
        }

        [Test]
        public void AddTest()
        {
            Assert.AreEqual(5,calc.Add(2,3));
        }

        [Test]
        public void DivTest()
        {
            Assert.Throws<DivideByZeroException>(new TestDelegate(()=>calc.Div(4,0)));
        }
    }
}