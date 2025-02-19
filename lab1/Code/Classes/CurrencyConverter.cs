using lab1.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1.Classes
{
	public static class CurrencyConverter
	{
		private static readonly Dictionary<(CurrencyType, CurrencyType), decimal> _exchangeRates = new()
						{
							{ (CurrencyType.USD, CurrencyType.EUR), 0.85m },
							{ (CurrencyType.EUR, CurrencyType.USD), 1.18m },
							{ (CurrencyType.USD, CurrencyType.UAH), 40.5m },
							{ (CurrencyType.UAH, CurrencyType.USD), 0.036m },
							{ (CurrencyType.EUR, CurrencyType.UAH), 45.3m },
							{ (CurrencyType.UAH, CurrencyType.EUR), 0.031m }
						};

		public static void AddExchangeRate(CurrencyType fromCurrency, CurrencyType toCurrency, decimal rate)
		{
			if (rate <= 0) throw new ArgumentException("Exchange rate must be positive.");

			_exchangeRates[(fromCurrency, toCurrency)] = rate;
			_exchangeRates[(toCurrency, fromCurrency)] = 1 / rate;
		}

		public static decimal Convert(decimal amount, CurrencyType fromCurrency, CurrencyType toCurrency)
		{

			if (fromCurrency == toCurrency) return amount;

			if (!_exchangeRates.TryGetValue((fromCurrency, toCurrency), out var rate))
				throw new InvalidOperationException($"Exchange rate from {fromCurrency} to {toCurrency} not found.");

			return amount * rate;
		}

		public static Money Convert(Money money, CurrencyType toCurrency)
		{
			decimal convertedAmount = Convert(money.GetAmount(), money.Currency, toCurrency);
			return new Money(convertedAmount, toCurrency);
		}
	}

}
