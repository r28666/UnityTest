using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using UnityTest.Interfaces;

namespace UnityTest.Implementations
{
	public class NullOutput : IOutput
	{
		public void WriteMessage(string msg)
		{
		}
	}
}
