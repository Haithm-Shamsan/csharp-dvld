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
    public partial class frmManageTestsTypes : Form
    { 

        public frmManageTestsTypes()
        {
            InitializeComponent();
        }

       void _Refresh()
        {
            dgvTestsType.DataSource = clsTestTypes.GetTestTypes();
            lblRecordsNumber.Text=dgvTestsType.Rows.Count.ToString();
        }
        private void frmManageTestsTypes_Load(object sender, EventArgs e)
        {
            _Refresh();
        }

        private void updateApplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new frmUpdateTest((int)dgvTestsType.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
            _Refresh();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
