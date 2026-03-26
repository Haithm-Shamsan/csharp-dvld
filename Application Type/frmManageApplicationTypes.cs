using DVLD_BussnisLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD
{
    public partial class frmManageApplicationTypes : Form
    { 

        public frmManageApplicationTypes()
        {
            InitializeComponent();
        }

        void _Refreash()
        {
            dgvApplicationType.DataSource = clsApplicationType.GetApplicationTypes();
            lblRecordsNumber.Text=dgvApplicationType.Rows.Count.ToString();
        }
        private void frmManageApplicationTypes_Load(object sender, EventArgs e)
        {
            _Refreash();
        }

        private void updateApplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new frmUpdateApplicationType((int)dgvApplicationType.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
            _Refreash();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
