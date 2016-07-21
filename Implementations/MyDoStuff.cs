using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using UnityTest.Interfaces;

namespace UnityTest.Implementations

{
	public class MyDoStuff : IDoStuffs
	{
		public int DoMoreStuff(int x, int y)
		{
			return x + y;
		}

		public int DoStuff(int x)
		{
			return x + x;
		}
	}
}
