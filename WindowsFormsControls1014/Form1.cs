using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsControls1014
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void 회원관리ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			frmMember frm = new frmMember();
			frm.MdiParent = this;
			frm.Show();
		}

		private void 제품관리ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			frmProduct frm = new frmProduct();
			frm.MdiParent = this;
			frm.Show();
		}
	}
}
