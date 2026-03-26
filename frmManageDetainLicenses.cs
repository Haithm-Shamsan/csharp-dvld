using DVLD.Applications.Detain_License;
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
    public partial class frmManageDetainLicenses : Form
    {
        public frmManageDetainLicenses()
        {
            InitializeComponent();
        }
        DataTable dtFilter = clsDetainedLicense.GetAllDetainedLicenses();
        void _Reafesh()
        {
            dgvDetainLicenses.DataSource = dtFilter.DefaultView.Table;
        }


        private void frmManageDetainLicenses_Load(object sender, EventArgs e)
        {
            _Reafesh();
        }

        private void cbFilterBy_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            txtFilter.Visible = true;
           
        }

        private void txtFilter_TextChanged(object sender, EventArgs e)
        {
            string FilterColumn = "";
            //Map Selected Filter to real Column name 
            switch (cbFilterBy.Text)
            {
                case "DetainID":
                    FilterColumn = "DetainID";
                    break;
             

                case "NationalNo":
                    FilterColumn = "NationalNo";
                    break;


                case "FullName":
                    FilterColumn = "FullName";
                    break;

                default:
                    FilterColumn = "None";
                    break;
            }


            //Reset the filters in case nothing selected or filter value conains nothing.
            if (txtFilter.Text.Trim() == "" || FilterColumn == "None")
            {
                dtFilter.DefaultView.RowFilter = "";
               
                return;
            }


            if (FilterColumn == "DetainID" || FilterColumn == "ReleaseApplicationID")
                //in this case we deal with numbers not string.
                dtFilter.DefaultView.RowFilter = string.Format("[{0}] = {1}", FilterColumn, txtFilter.Text.Trim());
            else
                dtFilter.DefaultView.RowFilter = string.Format("[{0}] LIKE '{1}%'", FilterColumn, txtFilter.Text.Trim());

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form frm = new frmDetainLicense();
            frm.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmReleaceDetainLicense frm = new frmReleaceDetainLicense();
            frm.ShowDialog();
        }

        private void showLicenseInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm=new frmLicenseInfo((int)dgvDetainLicenses.CurrentRow.Cells[1].Value);
            frm.ShowDialog();
        }

        private void showToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int PersonID = clsPeople.GetPerson((string)dgvDetainLicenses.CurrentRow.Cells[6].Value).PersonID;
            Person_Details personInfo=new Person_Details(PersonID);
            personInfo.ShowDialog();
        }

        private void licensesHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int PersonID = clsPeople.GetPerson((string)dgvDetainLicenses.CurrentRow.Cells[6].Value).PersonID;

            frmLicenseHistory frm=new frmLicenseHistory(PersonID); frm.ShowDialog();

        }

        private void realesDetainLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmReleaceDetainLicense frm = new frmReleaceDetainLicense((int)dgvDetainLicenses.CurrentRow.Cells[1].Value);
            frm.ShowDialog();

        }

        private void txtFilter_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(cbFilterBy.Text=="PersonID"||cbFilterBy.Text=="UserID")
               e.Handled=!char.IsDigit(e.KeyChar)||!char.IsControl(e.KeyChar);
        }
    }
}
