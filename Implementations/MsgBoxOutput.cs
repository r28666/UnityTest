using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using UnityTest.Interfaces;

namespace UnityTest.Implementations
{
	public class MsgBoxOutput : IOutput
	{
		public void WriteMessage(string msg)
		{
			MessageBox.Show(msg);
		}
	}
}
