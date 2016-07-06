using GiftAidCalculator.TestConsole;
using Moq;
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
        public void CalculateGiftAidAmount_ForDonationOf100WithTaxRateOf20_ReturnsGiftAidOf25()
        {
            var calculator = new Calculator(20m);
            Assert.AreEqual(25m, calculator.CalculateGiftAidAmount(100));
        }

        [Test]
        public void CalculateGiftAidAmount_ForDonationOf100WithTaxRateOf40_ReturnsGiftAidOf66()
        {
            var calculator = new Calculator(40m);
            Assert.AreEqual(100m * (2/3m), calculator.CalculateGiftAidAmount(100));
        }

        [Test]
        public void CalculateGiftAidAmount_WithAPromotion_ReturnsWhateverThePromotionSays()
        {
            var promotionMock = new Mock<IPromotion>();
            // we expect the mock to be called with the donation value
            promotionMock.Setup(promotion => promotion.Apply(25m)).Returns(187.55m);

            var calculator = new Calculator(20m);
            Assert.AreEqual(187.55m, calculator.CalculateGiftAidAmount(100, promotionMock.Object));
        }

    }
}
