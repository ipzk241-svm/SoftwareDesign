﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter.interfaces
{
	internal interface ILogger
	{
		void Log(string message);
		void Error(string message);
		void Warn(string message);
	}
}
