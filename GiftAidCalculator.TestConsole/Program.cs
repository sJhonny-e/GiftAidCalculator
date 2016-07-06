using System;

namespace GiftAidCalculator.TestConsole
{
	class Program
	{
		static void Main(string[] args)
		{
            // Calc Gift Aid Based on Previous
            Console.WriteLine("Please Enter tax rate (i.e 20 or 25.7):");
            var taxRate = decimal.Parse(Console.ReadLine());
            var calculator = new Calculator(taxRate);
            var presenter = new AmountPresenter();

            Console.WriteLine("Please Enter donation amount:");
            var amount = calculator.CalculateGiftAidAmount(decimal.Parse(Console.ReadLine()));
            Console.WriteLine(presenter.GetAmountForDisplay(amount));
			Console.WriteLine("Press any key to exit.");
			Console.ReadLine();
		}
        		
	}
}
