using System;
using System.Collections.Generic;

namespace Mediator.classes
{
	public class CommandCentre : IAirTrafficMediator
	{
		private List<Runway> _runways = new List<Runway>();
		private List<Aircraft> _aircrafts = new List<Aircraft>();

		public CommandCentre() { }

		public void RegisterRunway(Runway runway)
		{
			_runways.Add(runway);
		}

		public void RegisterAircraft(Aircraft aircraft)
		{
			_aircrafts.Add(aircraft);
		}

		public void RequestLanding(Aircraft aircraft)
		{
			foreach (var runway in _runways)
			{
				if (!runway.IsOccupied)
				{
					runway.Occupy();
					return;
				}
			}

			Console.WriteLine($"^^ No available runways for aircraft {aircraft.Name}.");
		}

		public void NotifyTakeOff(Aircraft aircraft)
		{
			foreach (var runway in _runways)
			{
				if (runway.IsOccupied)
				{
					runway.Release();
					return;
				}
			}

			Console.WriteLine($"?? Aircraft {aircraft.Name} was not found on any runway.");
		}
	}
}
