using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GiftAidCalculator.TestConsole
{
    public class AmountPresenter
    {
        public decimal GetAmountForDisplay(decimal amount)
        {
            return Math.Round(amount, 2);
        }
    }
}
