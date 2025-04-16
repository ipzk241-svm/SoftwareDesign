using System;

namespace Mediator.classes
{
	public class Runway
	{
		public Guid Id { get; } = Guid.NewGuid();
		public Aircraft? OccupiedBy { get; private set; }
		private IAirTrafficMediator _mediator;

		public Runway(IAirTrafficMediator mediator)
		{
			_mediator = mediator;
		}

		public bool IsAvailable => OccupiedBy == null;

		public void Occupy(Aircraft aircraft)
		{
			OccupiedBy = aircraft;
			Console.WriteLine($"+ Aircraft {aircraft.Name} landed on Runway {Id}");
			HighlightRed();
		}

		public void Release()
		{
			Console.WriteLine($"- Aircraft {OccupiedBy?.Name} took off from Runway {Id}");
			OccupiedBy = null;
			HighlightGreen();
		}

		private void HighlightRed() => Console.WriteLine($"!! Runway {Id} is now busy.");
		private void HighlightGreen() => Console.WriteLine($"** Runway {Id} is now free.");
	}
}
