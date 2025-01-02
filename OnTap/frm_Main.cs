using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OnTap
{
    public partial class frm_Main : Form
    {
        public frm_Main()
        {
            InitializeComponent();
            this.IsMdiContainer = true;
        }

        private void đăngKýToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["frm_HoSo"] == null)
            {
                frm_HoSo formHoSo = new frm_HoSo();
                formHoSo.MdiParent = this;
                formHoSo.Show();
            }
            else
            {
                Application.OpenForms["frm_HoSo"].Activate();
            }
        }
    }
}
