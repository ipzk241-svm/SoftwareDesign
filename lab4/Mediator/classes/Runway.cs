using System;

namespace Mediator.classes
{
	public class Runway
	{
		public Guid Id { get; } = Guid.NewGuid();
		public bool IsOccupied { get; private set; }
		private IAirTrafficMediator _mediator;

		public Runway(IAirTrafficMediator mediator)
		{
			_mediator = mediator;
		}


		public void Occupy()
		{
			IsOccupied = true;
			Console.WriteLine($"+ Aircraft landed on Runway {Id}");
			HighlightRed();
		}

		public void Release()
		{
			Console.WriteLine($"- Aircraft took off from Runway {Id}");
			IsOccupied = false;
			HighlightGreen();
		}

		private void HighlightRed() => Console.WriteLine($"!! Runway {Id} is now busy.");
		private void HighlightGreen() => Console.WriteLine($"** Runway {Id} is now free.");
	}
}
