using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestArduinoCOM
{
	public static class ExCtrls
	{
		public static void changeCtrlAsync(this Control c, Action a)
		{
			if (c.InvokeRequired)
				c.Invoke(a);
			else
				a();
		}

		public async static Task<DialogResult> ShowDialogAsync(this Form f)
		{
			await Task.Yield();
			if (f.IsDisposed)
				return DialogResult.OK;
			return f.ShowDialog();
		}
	}
}
