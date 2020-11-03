using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exception
{
    public class ImpossiblePurchase : SystemException
    {
        static void Main() { }
        public override string ToString()
        {
            return "ImpossiblePurchase!";
        }
    }
}
