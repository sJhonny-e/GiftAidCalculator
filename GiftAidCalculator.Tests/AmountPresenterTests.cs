using GiftAidCalculator.TestConsole;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GiftAidCalculator.Tests
{
    [TestFixture]
    public class AmountPresenterTests
    {
        [Test]
        public void GetAmountForDisplay_For2_123_RoundsTo2_12()
        {
            var presenter = new AmountPresenter();
            Assert.AreEqual(2.12m, presenter.GetAmountForDisplay(2.123m));
        }

        [Test]
        public void GetAmountForDisplay_For2_126_RoundsTo2_13()
        {
            var presenter = new AmountPresenter();
            Assert.AreEqual(2.13m, presenter.GetAmountForDisplay(2.126m));
        }

        [Test]
        public void GetAmountForDisplay_For2_125_RoundsTo2_12()
        {
            var presenter = new AmountPresenter();
            Assert.AreEqual(2.12m, presenter.GetAmountForDisplay(2.125m));
        }

        [Test]
        public void GetAmountForDisplay_For2_12_Remains2_12()
        {
            var presenter = new AmountPresenter();
            Assert.AreEqual(2.12m, presenter.GetAmountForDisplay(2.12m));
        }
    }
}
