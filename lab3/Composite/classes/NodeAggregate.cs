﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite.classes
{
	public interface INodeAggregate : IEnumerable
	{
		public abstract IEnumerator GetEnumerator();
	}
}
