using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Microsoft.Practices.Unity;
using Microsoft.Practices.Unity.Configuration;
using System.Configuration;

using UnityTest.Interfaces;
using Microsoft.Practices.ServiceLocation;


// Note:	The Implementations.dll is not referenced so you will need to copy it to the output folder before you run this app.

namespace UnityTest
{
	// Comment added to test GitHub
	class Program
	{
		static void Main(string[] args)
		{
#if false

			UnityContainer u = new UnityContainer();
			u.RegisterType<IRunner, MyRunner>();
			u.RegisterType<IDoStuffs, MyDoStuff>();
#else
			IUnityContainer u = new UnityContainer();

			try
			{
				u.LoadConfiguration(ConfigurationManager.AppSettings["WhichOne"]);

				// Converting a UnityContainer to an IServiceLocator - see MyRunner.cs
				u.RegisterInstance<IServiceLocator>(new UnityServiceLocator(u));
			}
			catch (Exception ex)
			{
				string s = ex.Message;
			}
#endif
			IRunner r = u.Resolve<IRunner>();

			r.Run();
		}
	}
}
