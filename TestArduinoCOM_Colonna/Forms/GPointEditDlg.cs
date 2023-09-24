using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestArduinoCOM
{
	public partial class GPointEditDlg : Form, IGPointEditView
	{
		public GPointEditDlg()
		{
			InitializeComponent();
		}

		public decimal res_alco => numericUpDown1.Value;

		public string res_comment => richTextBox1.Text;

		public bool Dispaly(decimal alco, string comm)
		{
			numericUpDown1.Value = alco;
			richTextBox1.Text = comm;

			this.ShowDialog();

			return DialogResult.OK == DialogResult;
		}
	}
}
