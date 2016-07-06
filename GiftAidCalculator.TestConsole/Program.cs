using System;

namespace GiftAidCalculator.TestConsole
{
	class Program
	{
		static void Main(string[] args)
		{
            // Calc Gift Aid Based on Previous
            var calculator = new Calculator();
			Console.WriteLine("Please Enter donation amount:");
			Console.WriteLine(calculator.CalculateGiftAidAmount(decimal.Parse(Console.ReadLine())));
			Console.WriteLine("Press any key to exit.");
			Console.ReadLine();
		}
        		
	}
}
