using Microsoft.VisualStudio.TestTools.UnitTesting;
using CITest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CITest.Tests
{
    [TestClass()]
    public class UdregningTests
    {
        [TestMethod()]
        public void AddTest()
        {
            //Arrange

            Udregning udregning = new Udregning();

            int expected = 4;

            // Act

            int acutual = udregning.Add(2, 2);

            //

            // Assert

            Assert.AreEqual(expected, acutual);
        }

        [TestMethod()]
        public void SubtractTest()
        {
            //Arrange

            Udregning udregning2 = new Udregning();

            int expected = 3;

            // Act

            int acutual = udregning2.Subtract(5, 2);

            //

            // Assert

            Assert.AreEqual(expected, acutual);
        }
    }
}