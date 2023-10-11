// { autofold
﻿using System;
using System.Linq;
using System.Text;

namespace Answer
{
	public class SalesTaxCalculatorStub
{


    public static decimal GetTotalAmount(decimal itemPrice, decimal taxRatePercent)
    {
			decimal taxRate = taxRatePercent / 100 ; //fix me
            return itemPrice + itemPrice * taxRate;
            
    }

}
}
//}
