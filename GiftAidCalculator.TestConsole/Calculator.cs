using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GiftAidCalculator.TestConsole
{
    public class Calculator
    {
        private const decimal TAX_RATE = 20m;
        public decimal CalculateGiftAidAmount(decimal donationAmount)
        {
            var ratio = TAX_RATE / (100 - TAX_RATE);
            return donationAmount * ratio;
        }
    }
}
