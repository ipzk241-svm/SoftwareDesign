using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FabricMethod.interfaces
{
	interface ISubscription
	{
		public abstract string Name { get; }
		public abstract decimal MonthlyFee { get; }
		public abstract int MinPeriod { get; }
		public abstract List<string> Channels { get; }
		public List<string> Features { get; }
		public abstract DateTime SubscriptionStartDate { get; }
		public abstract DateTime SubscriptionEndDate { get; }
		public abstract bool IsAutoRenewal { get; }
	}
}
