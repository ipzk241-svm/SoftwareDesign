using System;

namespace Mediator.classes
{
	public class Aircraft
	{
		public string Name { get; }
		public bool IsTakingOff { get; private set; }
		private IAirTrafficMediator _mediator;

		public Aircraft(string name, IAirTrafficMediator mediator)
		{
			Name = name;
			_mediator = mediator;
		}

		public void RequestLanding()
		{
			Console.WriteLine($"+++ Aircraft {Name} is requesting landing.");
			_mediator.RequestLanding(this);
		}

		public void TakeOff()
		{
			Console.WriteLine($"--- Aircraft {Name} is preparing for takeoff.");
			IsTakingOff = true;
			_mediator.NotifyTakeOff(this);
			IsTakingOff = false;
		}
	}
}
