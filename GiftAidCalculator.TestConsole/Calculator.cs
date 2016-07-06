using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GiftAidCalculator.TestConsole
{
    public class Calculator
    {
        private decimal _taxRate;

        public Calculator(decimal taxRate)
        {
            _taxRate = taxRate;
        }
        public decimal CalculateGiftAidAmount(decimal donationAmount, IPromotion promotion = null)
        {
            var ratio = _taxRate / (100 - _taxRate);
            var donation = donationAmount * ratio;
            return promotion != null ? promotion.Apply(donation) : donation;
        }

    }
}
