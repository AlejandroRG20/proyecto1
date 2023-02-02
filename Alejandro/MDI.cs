using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Alejandro
{
    public partial class MDI : Form
    {
        Form1 a=new Form1();
        Form2 b=new Form2();
        Form3 c=new Form3();
        public MDI()
        {

            InitializeComponent();
            IsMdiContainer = true;
        }

        private void prestamoBancoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            a.MdiParent = this;
            a.Show();
        }

        private void calculoDeDepreciacionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            b.MdiParent = this;
            b.Show();
        }

        private void facturaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            c.MdiParent = this;
            c.Show();
        }
    }
}
