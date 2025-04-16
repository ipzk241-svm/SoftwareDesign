using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator.classes
{
	public class BaseComponent
	{
		protected IAirTrafficMediator? _mediator;

		public void SetMediator(IAirTrafficMediator mediator)
		{
			this._mediator = mediator;
		}
	}
}
