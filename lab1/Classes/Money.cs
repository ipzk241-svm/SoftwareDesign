using lab1.Interfaces;

public class Money : IMoney
{
	public int Whole { get; private set; }
	public int Small { get; private set; }
	public string Currency { get; }

	public Money(int whole, int small, string currency)
	{
		Whole = whole;
		Small = small;
		Currency = currency;
	}
	public Money(decimal amount, string currency)
	{
		Whole = (int)amount;
		Small = (int)((amount - Whole) * 100);
		Currency = currency;
	}

	public decimal GetAmount()
	{
		return Whole + Small / 100m;
	}

	public void SetWhole(int whole)
	{
		Whole = whole;
	}

	public void SetSmall(int small)
	{
		Small = small;
	}

	public void Display()
	{
		Console.WriteLine(ToString());
	}

	public override string ToString()
	{
		return $"{Whole}.{Small:D2} {Currency}";
	}
	public static Money operator -(Money m1, Money m2)
	{
		if (m1.Currency != m2.Currency)
			throw new InvalidOperationException("Cannot subtract amounts with different currencies");
		int totalSmall = m1.Small - m2.Small;
		int totalWhole = m1.Whole - m2.Whole;
		if (totalSmall < 0)
		{
			totalWhole--;
			totalSmall += 100;
		}
		return new Money(totalWhole, totalSmall, m1.Currency);
	}
	public static Money operator +(Money m1, Money m2)
	{
		if (m1.Currency != m2.Currency)
			throw new InvalidOperationException("Cannot add amounts with different currencies");

		int totalSmall = m1.Small + m2.Small;
		int totalWhole = m1.Whole + m2.Whole + totalSmall / 100;
		totalSmall %= 100;

		return new Money(totalWhole, totalSmall, m1.Currency);
	}

	public static Money operator *(Money m1, Money m2)
	{
		if (m1.Currency != m2.Currency)
			throw new InvalidOperationException("Cannot multiply amounts with different currencies");

		decimal amount = m1.GetAmount() * m2.GetAmount();
		int whole = (int)amount;
		int small = (int)((amount - whole) * 100);

		return new Money(whole, small, m1.Currency);
	}

	public static Money operator /(Money m1, Money m2)
	{
		if (m1.Currency != m2.Currency)
			throw new InvalidOperationException("Cannot divide amounts with different currencies");

		decimal amount = m1.GetAmount() / m2.GetAmount();
		int whole = (int)amount;
		int small = (int)((amount - whole) * 100);

		return new Money(whole, small, m1.Currency);
	}
}
