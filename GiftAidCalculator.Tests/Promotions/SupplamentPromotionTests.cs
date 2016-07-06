using GiftAidCalculator.TestConsole.Promotions;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GiftAidCalculator.Tests.Promotions
{
    [TestFixture]
    public class SupplamentPromotionTests
    {
        [Test]
        public void Apply_With10PctAnd100Donation_Returns110()
        {
            var promotion = new SupplamentPromotion(10m);
            Assert.AreEqual(110m, promotion.Apply(100m));
        }

        [Test]
        public void Apply_With5PctAnd100Donation_Returns105()
        {
            var promotion = new SupplamentPromotion(5m);
            Assert.AreEqual(105m, promotion.Apply(100m));
        }

        [Test]
        public void Apply_With0PctAnd100Donation_Returns100()
        {
            var promotion = new SupplamentPromotion(0m);
            Assert.AreEqual(100m, promotion.Apply(100m));
        }
    }
}
