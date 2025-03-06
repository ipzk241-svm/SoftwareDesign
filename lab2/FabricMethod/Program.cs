using FabricMethod.classes;
using FabricMethod.interfaces;
using System;
using System.Text;

Console.OutputEncoding = Encoding.UTF8;
Console.InputEncoding = Encoding.UTF8;

SubscriptionFactory website = new WebSite();
SubscriptionFactory mobileApp = new MobileApp();
SubscriptionFactory managerCall = new ManagerCall();

try
{
	ISubscription domestic = website.CreateSubscription("domestic");
	Console.WriteLine(domestic);

	ISubscription educational = mobileApp.CreateSubscription("educational");
	Console.WriteLine(educational);

	ISubscription premium = managerCall.CreateSubscription("premium");
	Console.WriteLine(premium);
}
catch (ArgumentException ex)
{
	Console.WriteLine($"Помилка: {ex.Message}");
}
