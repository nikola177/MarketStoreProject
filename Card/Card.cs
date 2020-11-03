using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exception;

namespace Card
{
	public abstract class Card
	{
		private String owner;
		private double turnover;
		private double initialDiscountRate;

		static void Main() { }

		public Card(double turnover)
		{
			this.turnover = turnover;
		}

		public String getOwner()
		{
			return owner;
		}

		public double getTurnover()
		{
			return turnover;
		}

		public void setOwner(String owner)
		{
			this.owner = owner;
		}

		public void setTurnover(double turnover)
		{
			this.turnover = turnover;
		}

		public void setInitialDiscountRate(double initialDiscountRate)
		{
			this.initialDiscountRate = initialDiscountRate;
		}

		public abstract double GetInitialDiscountRate();

		public double CalculateDiscount(double purchase)
		{

			return Math.Round(purchase * (double)(GetInitialDiscountRate() / 100), 2, MidpointRounding.ToEven);
		}

		public double CalculateTotalPurchase(double purchase)
		{

			return Math.Round(purchase - CalculateDiscount(purchase), 2, MidpointRounding.ToEven);
		}

		public String RepresentationResult(double temporaryPurchase)
		{

			String result = "Purchase value: $" + temporaryPurchase + "\n" +
					"Discount rate: " + GetInitialDiscountRate() + "%\n" +
					"Discount : $" + CalculateDiscount(temporaryPurchase) + "\n" +
					"Total: $" + CalculateTotalPurchase(temporaryPurchase);

			return result;
		}

		public void PrintResult(double temporaryPurchase)
		{
			if (temporaryPurchase <= 0)
			{
				throw new ImpossiblePurchase();
			}

			Console.WriteLine(RepresentationResult(temporaryPurchase));
		}
	}
}