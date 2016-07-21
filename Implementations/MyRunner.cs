using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Microsoft.Practices.Unity;


using UnityTest.Interfaces;
using Microsoft.Practices.ServiceLocation;


namespace UnityTest.Implementations
{
	public class MyRunner : IRunner
	{
		private IDoStuffs _DoStuffs;
		private IOutput _Output;
		private List<IOutput> _AllOutputs;

#if false
		public MyRunner(IUnityContainer locator, IDoStuffs doStuffs, IOutput output)
		{
			_DoStuffs = doStuffs;
			_Output = output;
			_AllOutputs = new List<IOutput>(locator.ResolveAll<IOutput>());
		}

#else
		public MyRunner(IServiceLocator locator, IDoStuffs doStuffs, IOutput output)
		{
			_DoStuffs = doStuffs;
			_Output = output;
			_AllOutputs = new List<IOutput>(locator.GetAllInstances<IOutput>());
		}
#endif

		public void Run()
		{
			for (int i = 0; i < 10; i++)
			{
				string s = _DoStuffs.DoMoreStuff(i, i).ToString();
				_Output.WriteMessage(s);

				foreach (var v in _AllOutputs)
					v.WriteMessage(s);
			}
		}
	}
}
