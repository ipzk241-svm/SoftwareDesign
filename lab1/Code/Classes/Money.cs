using lab1.Classes;
using lab1.Interfaces;

public class Money : IMoney
{
	public int Whole { get; protected set; }
	public int Fraction { get; protected set; }
	public CurrencyType Currency { get; protected set; }

	public Money(int whole, int fraction, CurrencyType currency)
	{
		Whole = whole;
		Fraction = fraction;
		Currency = currency;
	}
	public Money(decimal amount, CurrencyType currency)
	{
		Whole = (int)amount;
		Fraction = (int)Math.Round((amount - Whole) * 100, 2);
		Currency = currency;
	}

	public decimal GetAmount()
	{
		return Whole + Fraction / 100m;
	}

	public void SetWhole(int whole)
	{
		Whole = whole;
	}

	public void SetFraction(int Fraction)
	{
		Fraction = Fraction;
	}

	public void Display()
	{
		Console.WriteLine(ToString());
	}

	public override string ToString()
	{
		return $"{Whole}.{Fraction:D2} {Currency}";
	}
	public static Money operator -(Money m1, Money m2)
	{
		if (m1 == null || m2 == null)
			throw new ArgumentNullException("Money objects cannot be null");

		Money secondOperand = (m1.Currency == m2.Currency) ? m2 : CurrencyConverter.Convert(m2, m1.Currency);

		int totalFraction = m1.Fraction - secondOperand.Fraction;
		int totalWhole = m1.Whole - secondOperand.Whole;
		if (totalFraction < 0)
		{
			totalWhole--;
			totalFraction += 100;
		}
		return new Money(totalWhole, totalFraction, m1.Currency);
	}
	public static Money operator +(Money m1, Money m2)
	{
		if (m1 == null || m2 == null)
			throw new ArgumentNullException("Money objects cannot be null");

		Money secondOperand = (m1.Currency == m2.Currency) ? m2 : CurrencyConverter.Convert(m2, m1.Currency);

		int totalFraction = m1.Fraction + secondOperand.Fraction;
		int totalWhole = m1.Whole + secondOperand.Whole + totalFraction / 100;
		totalFraction %= 100;

		return new Money(totalWhole, totalFraction, m1.Currency);

	}

	public static Money operator *(Money m1, Money m2)
	{
		if (m1 == null || m2 == null)
			throw new ArgumentNullException("Money objects cannot be null");

		Money secondOperand = (m1.Currency == m2.Currency) ? m2 : CurrencyConverter.Convert(m2, m1.Currency);

		decimal amount = m1.GetAmount() * secondOperand.GetAmount();
		int whole = (int)amount;
		int fraction = (int)((amount - whole) * 100);

		return new Money(whole, fraction, m1.Currency);
	}

	public static Money operator *(Money m1, decimal mult)
	{
		if (m1 == null)
			throw new ArgumentNullException("Money objects cannot be null");

		decimal amount = m1.GetAmount() * mult;
		int whole = (int)amount;
		int fraction = (int)((amount - whole) * 100);

		return new Money(whole, fraction, m1.Currency);
	}

	public static Money operator /(Money m1, Money m2)
	{
		if (m1 == null || m2 == null)
			throw new ArgumentNullException("Money objects cannot be null");

		Money secondOperand = (m1.Currency == m2.Currency) ? m2 : CurrencyConverter.Convert(m2, m1.Currency);

		decimal amount = m1.GetAmount() / secondOperand.GetAmount();
		int whole = (int)amount;
		int fraction = (int)((amount - whole) * 100);

		return new Money(whole, fraction, m1.Currency);
	}
	public static Money operator /(Money m1, decimal div)
	{
		if (m1 == null)
			throw new ArgumentNullException("Money objects cannot be null");

		decimal amount = m1.GetAmount() / div;
		int whole = (int)amount;
		int fraction = (int)((amount - whole) * 100);

		return new Money(whole, fraction, m1.Currency);
	}
}
