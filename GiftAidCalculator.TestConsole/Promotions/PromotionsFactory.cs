using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GiftAidCalculator.TestConsole.Promotions
{
    public class PromotionsFactory
    {
        public IPromotion GetPromotion(EventType eventType)
        {
            switch (eventType)
            {
                case EventType.Running:
                    return new SupplamentPromotion(5);
                case EventType.Swimming:
                    return new SupplamentPromotion(3);
                case EventType.Flying:
                case EventType.Biking:
                case EventType.Hiking:
                case EventType.Other:
                default:
                    return null;
            }

        }
    }
}
