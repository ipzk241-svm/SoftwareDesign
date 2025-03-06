using FabricMethod.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FabricMethod.classes
{
	internal class ManagerCall : SubscriptionFactory
	{

		public override ISubscription CreateSubscription(SubscriptionType type)
		{
			Console.WriteLine("Створення підписки через дзвінок менеджеру...");
			return type switch
			{
				SubscriptionType.DOMESTIC => new DomesticSubscription(),
				SubscriptionType.EDUCATIONAL => new EducationalSubscription(),
				SubscriptionType.PREMIUM => new PremiumSubscription(),
				_ => throw new ArgumentException("Невідомий тип підписки")
			};
		}
	}
}
