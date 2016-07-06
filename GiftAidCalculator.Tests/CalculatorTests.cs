using GiftAidCalculator.TestConsole;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GiftAidCalculator.Tests
{

    [TestFixture]
    public class CalculatorTests
    {
        [Test]
        public void CalculateGiftAidAmount_ForDonationOf100_ReturnsGiftAidOf25()
        {
            var calculator = new Calculator();
            Assert.AreEqual(25m, calculator.CalculateGiftAidAmount(100));
        }
    }
}
