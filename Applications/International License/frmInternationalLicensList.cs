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
    public partial class frmInternationalLicensList : Form
    {
        public frmInternationalLicensList()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void cmbFilterBy()
        {
            DataTable _dtInternationalLicenseApplications = clsInternationalLicense.GetAllInternationalLicenses();
            DataView Search = clsApplication.GetApplications().DefaultView;

            string FilterColumn = "";
            //Map Selected Filter to real Column name
          
            switch (cbmFilterBy.Text)
            {
                case "International License ID":

                    FilterColumn = "InternationalLicenseID";

                 
                        break;
                case "Application ID":
                    {
                     
                        FilterColumn = "ApplicationID";
                        break;
                    };

                case "Driver ID":
                    FilterColumn = "DriverID";
                    break;

                case "Local License ID":
                    FilterColumn = "IssuedUsingLocalLicenseID";
                    break;

                
            }
  
            

            //Reset the filters in case nothing selected or filter value conains nothing.
            if (cbmFilterBy.Text.Trim() == "" || FilterColumn == "None")
            {
                _dtInternationalLicenseApplications = null;
                lblRecordsNumber.Text = dataGridView1.Rows.Count.ToString();
                return;
            }

                    if (int.TryParse( cbmFilterBy.Text, out int PersonID))
                    {
                        _dtInternationalLicenseApplications.DefaultView.RowFilter = string.Format("'{0}'='{1}'", FilterColumn, PersonID);
                        dataGridView1.DataSource = _dtInternationalLicenseApplications;
                    }
          



            lblRecordsNumber.Text = _dtInternationalLicenseApplications.Rows.Count.ToString();

            dataGridView1.DataSource = _dtInternationalLicenseApplications;
        }

        private void cbmFilterBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbmFilterBy.Visible = true;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmAddNewInterNationalDrivingLicense frm = new frmAddNewInterNationalDrivingLicense();
            frm.ShowDialog();
        }

        private void txtFilter_TextChanged(object sender, EventArgs e)
        {
            DataTable _dtInternationalLicenseApplications = clsInternationalLicense.GetAllInternationalLicenses();
            string FilterColumn = "";
            //Map Selected Filter to real Column name 
            switch (cbmFilterBy.Text)
            {
                case "International License ID":
                    FilterColumn = "InternationalLicenseID";
                    break;
                case "Application ID":
                    {
                        FilterColumn = "ApplicationID";
                        break;
                    };

                case "Driver ID":
                    FilterColumn = "DriverID";
                    break;

                case "Local License ID":
                    FilterColumn = "IssuedUsingLocalLicenseID";
                    break;

                case "Is Active":
                    FilterColumn = "IsActive";
                    break;


                default:
                    FilterColumn = "None";
                    break;
            }


            //Reset the filters in case nothing selected or filter value conains nothing.
            if (cbmFilterBy.Text.Trim() == "" || FilterColumn == "None")
            {
                _dtInternationalLicenseApplications.DefaultView.RowFilter = "";
                lblRecordsNumber.Text = dataGridView1.Rows.Count.ToString();
                return;
            }



            _dtInternationalLicenseApplications.DefaultView.RowFilter = string.Format("{0} = {1}", FilterColumn, cbmFilterBy.Text.Trim());

            lblRecordsNumber.Text = _dtInternationalLicenseApplications.Rows.Count.ToString();
        }

        private void frmInternationalLicensList_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = clsInternationalLicense.GetAllInternationalLicenses();
        }

        private void cbmFilterBy_SelectedValueChanged(object sender, EventArgs e)
        {
            DataTable _dtInternationalLicenseApplications = clsInternationalLicense.GetAllInternationalLicenses();
            string FilterColumn = "";
            //Map Selected Filter to real Column name 
            switch (cbmFilterBy.Text)
            {
                case "International License ID":
                    FilterColumn = "InternationalLicenseID";
                    break;
                case "Application ID":
                    {
                        FilterColumn = "ApplicationID";
                        break;
                    };

                case "Driver ID":
                    FilterColumn = "DriverID";
                    break;

                case "Local License ID":
                    FilterColumn = "IssuedUsingLocalLicenseID";
                    break;

                case "Is Active":
                    FilterColumn = "IsActive";
                    break;


                default:
                    FilterColumn = "None";
                    break;
            }


            //Reset the filters in case nothing selected or filter value conains nothing.
            if (cbmFilterBy.Text.Trim() == "" || FilterColumn == "None")
            {
                _dtInternationalLicenseApplications.DefaultView.RowFilter = "";
                lblRecordsNumber.Text = dataGridView1.Rows.Count.ToString();
                return;
            }



            _dtInternationalLicenseApplications.DefaultView.RowFilter = string.Format("{0} = {1}", FilterColumn, cbmFilterBy.Text.Trim());

            lblRecordsNumber.Text = _dtInternationalLicenseApplications.Rows.Count.ToString();
        }

        private void showDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int DriverID = (int)dataGridView1.CurrentRow.Cells[2].Value;

            Form frm = new Person_Details(clsDriver.GetDriverByID(DriverID).PersonID);
            frm.ShowDialog();
        }

        private void licenseInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new frmInternationalLicense((int)dataGridView1.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
        }

        private void driverLicenseHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int DriverID = (int)dataGridView1.CurrentRow.Cells[2].Value;

            Form frm = new frmLicenseHistory(clsDriver.GetDriverByID(DriverID).PersonID);
            frm.ShowDialog();
        }

        private void cbFilterBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }

    
}
    

