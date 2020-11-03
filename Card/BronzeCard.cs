using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Card
{
	public class BronzeCard : Card
	{
		public BronzeCard(double turnover) : base(turnover)
		{

		}
		public override double GetInitialDiscountRate()
		{

			double result;

			if (getTurnover() <= 100)
			{
				result = 0;
			}
			else if (getTurnover() <= 300)
			{
				result = 1;
			}
			else
			{
				result = 2.5;
			}

			return result;
		}
	}
}
