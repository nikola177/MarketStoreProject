using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Card
{
	public class GoldCard : Card
	{
		public GoldCard(double turnover) : base(turnover)
		{

		}
		public override double GetInitialDiscountRate()
		{

			double result = 2;

			int x = (int)getTurnover() / 100;

			result += x;

			if (result >= 10)
			{
				result = 10;
			}

			return result;
		}
	}
}
