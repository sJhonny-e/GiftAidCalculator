using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GiftAidCalculator.TestConsole
{
    public interface IPromotion
    {
        decimal Apply(decimal donation);
    }
}
