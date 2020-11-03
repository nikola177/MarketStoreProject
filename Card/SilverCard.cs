using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Card
{
	public class SilverCard : Card
	{
		public SilverCard(double turnover) : base(turnover)
		{

		}
		public override double GetInitialDiscountRate()
		{

			double result;

			if (getTurnover() <= 300)
			{
				result = 2;
			}
			else
			{
				result = 3.5;
			}

			return result;
		}
	}
}
