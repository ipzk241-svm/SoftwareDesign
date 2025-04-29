using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite.classes
{
	 public abstract class Iterator : IEnumerator
	{
		object IEnumerator.Current => Current();
		public abstract LightNode Current();
		public abstract int Key();
		public abstract bool MoveNext();
		public abstract void Reset();
	}
}
