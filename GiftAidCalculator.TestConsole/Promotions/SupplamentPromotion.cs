using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GiftAidCalculator.TestConsole.Promotions
{
    public class SupplamentPromotion : IPromotion
    {
        private decimal _addedPercentage;
        public SupplamentPromotion(decimal addedPercentage)
        {
            _addedPercentage = addedPercentage;
        }
        public decimal Apply(decimal donation)
        {
            return donation + (_addedPercentage / 100) * donation;
        }
    }
}
