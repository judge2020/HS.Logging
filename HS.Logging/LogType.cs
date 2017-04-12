using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HSLogging
{
	[Flags]
	public enum LogType
	{
		Debug,
		Info,
		Warning,
		Error
	}
}
