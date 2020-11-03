using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exception;
using Card;

namespace Test
{
	public class Test
	{
		public static void Main()
		{

			Card.Card bronze = new BronzeCard(0);

			try
			{
				bronze.PrintResult(150);
			}
			catch (ImpossiblePurchase e)
			{
				Console.WriteLine(e);
			}

			Card.Card silver = new SilverCard(600);

			try
			{
				silver.PrintResult(850);
			}
			catch (ImpossiblePurchase e)
			{
				Console.WriteLine(e);
			}

			Card.Card gold = new GoldCard(1500);

			try
			{
				gold.PrintResult(1300);
			}
			catch (ImpossiblePurchase e)
			{
				Console.WriteLine(e);
			}
		}
	}
}
