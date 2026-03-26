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
    public partial class frmDriversList : Form
    {
        public frmDriversList()
        {
            InitializeComponent();
        }
        void _Refreash()
        {
            dataGridView1.DataSource=clsDriver.GetDrivers();
            lblRecordsNumber.Text=dataGridView1.RowCount.ToString();
        }
        private void cmbFilterBy()
        {
            DataView Search = clsDriver.GetDrivers().DefaultView;
            txtFilter.Visible = true;

            switch (cbmFilterBy.SelectedItem)
            {
                case "DriverID":

                    if (int.TryParse(txtFilter.Text, out int DriverID))
                    {
                        Search.RowFilter = string.Format("PersonID ='{0}'", DriverID);


                    }
                    dataGridView1.DataSource = Search;

                    break;


                case "PersonID":

                    if (int.TryParse(txtFilter.Text, out int PersonID))
                    {
                        Search.RowFilter = string.Format("PersonID ='{0}'", PersonID);


                    }
                    dataGridView1.DataSource = Search;

                    break;


            }
        }
        private void frmDriversList_Load(object sender, EventArgs e)
        {
            _Refreash();
        }

        private void txtFilter_TextChanged(object sender, EventArgs e)
        {
            cmbFilterBy();
        }

        private void cbmFilterBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtFilter.Visible = true;
            txtFilter.Text = "";
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {

            Form frm = new Person_Details((int)dataGridView1.CurrentRow.Cells[1].Value);
            frm.ShowDialog();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
          
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
