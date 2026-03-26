using DVLD_BussnisLayer;
using Guna.UI2.WinForms;
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
    public partial class frmRenewDrivingLicense : Form
    {

        int _LicenseID;
        int _OldLicenseID;

        public frmRenewDrivingLicense()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       void LoadLicenseData()
        {
            lblIssueDate.Text=clsFormating.DateToString(DateTime.Now);
            lblApplicationFees.Text = clsApplicationType.GetApplicationTypeByID((int)clsApplication.enApplicationType.RenewDrivingLicenseService).AppFees.ToString();
            lblApplicationDate.Text = lblIssueDate.Text;
            lblExpirationDate.Text = "[???]";
            lblCreatedBy.Text = clsGlobale.CurrentUser.UserName;
        }
        private void ctrLicenseInfoWithFilter1_OnLicenseSelected(int obj)
        {
            _OldLicenseID = obj;

            if(_OldLicenseID==-1)
            {
                return;
            }
            llShowLicenseHistory.Enabled =(_OldLicenseID!=-1);

           lblOldLicenseID.Text = _OldLicenseID.ToString();
            int ValiedLength = ctrLicenseInfoWithFilter1.SelectedLicenseInfo.LicenseClassInfo.DefaultValidityLength;
            lblExpirationDate.Text = DateTime.Now.AddYears(ValiedLength).ToString();
            lblLicenseFees.Text=clsLicense.Find(_OldLicenseID).PaidFees.ToString();
            lblTotalFees.Text = (Convert.ToSingle(lblApplicationFees.Text) + Convert.ToSingle(lblLicenseFees.Text)).ToString();
            




            if(!ctrLicenseInfoWithFilter1.SelectedLicenseInfo.IsLicenseExpaierd())
            {
                MessageBox.Show("Selected License is not yet expiared, it will expire on: " + clsFormating.DateToString(ctrLicenseInfoWithFilter1.SelectedLicenseInfo.ExpirationDate)
                   , "Not allowed", MessageBoxButtons.OK, MessageBoxIcon.Error) ;

                btnSave.Enabled = false;
                return;
            }

            if(!ctrLicenseInfoWithFilter1.SelectedLicenseInfo.IsActive)
            {
                MessageBox.Show("Selected License is not Active"
                  , "Not allowed", MessageBoxButtons.OK, MessageBoxIcon.Error);

                btnSave.Enabled = false;
                return;
            }
            
            btnSave.Enabled = true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
           if( MessageBox.Show("Are you sure do you want to Renew This License","Confirm",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.No)
            {
                return;
            }


            clsLicense NewLicense = ctrLicenseInfoWithFilter1.SelectedLicenseInfo.RenewDrivingLicense(txtNotes.Text.Trim(), clsGlobale.CurrentUser.UserID);

            if(NewLicense==null )
            {
               MessageBox.Show("Failed Renew License !","Failed",MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            lblRenewedLicenseID.Text = NewLicense.LicenseID.ToString();
            _LicenseID= NewLicense.LicenseID;
            MessageBox.Show("License Renewed Seccussfully With ID =  " + lblRenewedLicenseID.Text, "Renewed Seccussfuly", MessageBoxButtons.OK);
            llShowLicenseHistory.Enabled = true;
            btnSave.Enabled = false;
            llShowLicenseInfo.Enabled = false;
        
        
        }

        private void llShowLicenseInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmLicenseInfo frm = new frmLicenseInfo(_LicenseID);
            frm.ShowDialog();

        }

        private void llShowLicenseHistory_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            int PersonID = clsLicense.Find(_LicenseID).DriverInfo.PersonID;
            frmLicenseHistory frm = new frmLicenseHistory(PersonID);
            frm.ShowDialog();
        }

        private void ctrLicenseInfoWithFilter1_Load(object sender, EventArgs e)
        {

        }

        private void frmRenewDrivingLicense_Load(object sender, EventArgs e)
        {
            LoadLicenseData();
        }

        private void gpApplicationInfo_Enter(object sender, EventArgs e)
        {

        }
    }
}
