using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DeepMoney
{
	public interface ICurrencyConverter
	{
		double GetRate(CurrencyCodes fromCode, CurrencyCodes toCode, DateTime asOn);
		double GetRate(string fromCode, string toCode, DateTime asOn);
	}
}
