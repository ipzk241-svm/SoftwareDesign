using FabricMethod.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FabricMethod.classes
{
	abstract class SubscriptionFactory
	{
		abstract public ISubscription CreateSubscription(SubscriptionType type);
		
	}
}
