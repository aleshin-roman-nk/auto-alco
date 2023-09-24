using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TestArduinoCOM.BL;

namespace TestArduinoCOM
{
	public partial class ChooseSessionForm : Form
	{
		BindingSource bs = new BindingSource();

		public ChooseSessionForm()
		{
			InitializeComponent();

			dataGridView1.DataSource = bs;
		}

		Session current => bs.Current as Session;

		public Session Go(IEnumerable<Session> items)
		{
			bs.DataSource = items;

			if (this.ShowDialog() == DialogResult.OK)
			{
				return current;
			}
			else return null;
		}

		private void btnOk_Click(object sender, EventArgs e)
		{
			DialogResult = DialogResult.OK;
		}

		private void btnCancel_Click(object sender, EventArgs e)
		{
			DialogResult = DialogResult.Cancel;
		}
	}
}
