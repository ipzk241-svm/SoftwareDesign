using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.interfaces
{
	internal interface IHero
	{
		string GetDescription();
		int GetDamage();
		int GetDefense();
	}
}
