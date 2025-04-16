using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility.classes
{
	abstract class SupportHandler
	{
		protected SupportHandler? nextHandler;

		public SupportHandler SetNext(SupportHandler next)
		{
			nextHandler = next;

			return next;
		}

		public abstract bool Handle();
	}

}
