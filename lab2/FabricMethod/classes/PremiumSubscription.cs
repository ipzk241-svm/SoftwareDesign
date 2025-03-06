using FabricMethod.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FabricMethod.classes
{
	internal class PremiumSubscription: ISubscription
	{
		public string Name { get; set; }

		public decimal MonthlyFee { get; set; }

		public int MinPeriod { get; set; }

		public List<string> Channels { get; set; }

		public DateTime SubscriptionStartDate { get; set; }

		public DateTime SubscriptionEndDate { get; set; }

		public bool IsAutoRenewal { get; set; }

		public List<string> Features { get; set; }

		public PremiumSubscription(string name, decimal monthlyFee, int minPeriod, List<string> channels, List<string> features, DateTime startDate, DateTime endDate, bool isAutoRenewal)
		{
			Name = name;
			MonthlyFee = monthlyFee;
			MinPeriod = minPeriod;
			Channels = channels;
			SubscriptionStartDate = startDate;
			SubscriptionEndDate = endDate;
			IsAutoRenewal = isAutoRenewal;
			Features = features;
		}

		public PremiumSubscription()
		{
			Name = "Преміум";
			MonthlyFee = 20.0m;
			MinPeriod = 24;
			Channels = new List<string> { "Всі канали", "Фільми", "Спорт", "Преміум контент" };
			Features = new List<string> { "Якість 4K", "4 пристрої", "Перегляд офлайн" };
			SubscriptionStartDate = DateTime.Now;
			SubscriptionEndDate = DateTime.Now.AddYears(2);
			IsAutoRenewal = true;
		}

		public override string ToString()
		{
			string output = string.Empty;
			output += $"Підписка: {Name}\n";
			output += $"Щомісячна плата: {MonthlyFee} грн\n";
			output += $"Мінімальний період: {MinPeriod} місяців\n";
			output += $"Канали: {string.Join(", ", Channels)}\n";
			output += $"Дата початку підписки: {SubscriptionStartDate.ToShortDateString()}\n";
			output += $"Дата закінчення підписки: {SubscriptionEndDate.ToShortDateString()}\n";
			output += $"Автоматичне поновлення: {(IsAutoRenewal ? "Так" : "Ні")}\n";
			output += $"Особливості: {string.Join(", ", Features)}\n";

			return output;
		}
	}
}
