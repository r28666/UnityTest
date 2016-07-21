using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using UnityTest.Interfaces;

namespace UnityTest.Implementations
{
	public class MyOutput : IOutput
	{
		public void WriteMessage(string msg)
		{
			Console.WriteLine(msg);
		}
	}
}
