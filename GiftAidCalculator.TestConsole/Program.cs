using GiftAidCalculator.TestConsole.Promotions;
using System;
using System.Linq;

namespace GiftAidCalculator.TestConsole
{
	class Program
	{
		static void Main(string[] args)
        {
            var eventTypes = Enum.GetValues(typeof(EventType)).Cast<EventType>();
            var descriptions = string.Join("\n", eventTypes.Select(t => (int)t + ": " + Enum.GetName(typeof(EventType), t)));
            Console.WriteLine("Please choose event type:");
            Console.WriteLine(descriptions);
            var type = (EventType)int.Parse(Console.ReadLine());

            Console.WriteLine("Please Enter tax rate (i.e 20 or 25.7):");
            var taxRate = decimal.Parse(Console.ReadLine());

            // Poor man's DI
            var calculator = new Calculator(taxRate);
            var presenter = new AmountPresenter();
            IPromotion promotion = GetPromotion(type);

            Console.WriteLine("Please Enter donation amount:");
            var amount = calculator.CalculateGiftAidAmount(decimal.Parse(Console.ReadLine()), promotion);
            Console.WriteLine(presenter.GetAmountForDisplay(amount));
            Console.WriteLine("Press any key to exit.");
            Console.ReadLine();
        }

        private static IPromotion GetPromotion(EventType type)
        {
            var promotionsFactory = new PromotionsFactory();
            return promotionsFactory.GetPromotion(type);
        }
    }
}
