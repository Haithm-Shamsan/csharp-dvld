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

namespace DVLD.Applications.Detain_License
{
    public partial class frmReleaceDetainLicense : Form
    {  int LicenseID;
        
        public frmReleaceDetainLicense(int LicenseID)
        {
            InitializeComponent();
            this.LicenseID = LicenseID;
            ctrLicenseInfoWithFilter1.LoadInfo(LicenseID);
            ctrLicenseInfoWithFilter1.FilterEnable();
           
        }
        public frmReleaceDetainLicense()
        {
            InitializeComponent();
        }
        private void ctrLicenseInfoWithFilter1_OnLicenseSelected(int obj)
        {
            LicenseID = obj;
            if (LicenseID == -1)
                return;

            llShowLicenseHistory.Enabled = LicenseID != -1;

          if(ctrLicenseInfoWithFilter1.SelectedLicenseInfo.DetainedInfo.IsReleased)
            {
                btnSave.Enabled = false;
                MessageBox.Show("This License Isnt Detain !", "Error");
                return;
            }

            clsLicense License = clsLicense.Find(LicenseID);

           lblLicenseID.Text = LicenseID.ToString();
            lblExpirationDate.Text = clsFormating.DateToString(ctrLicenseInfoWithFilter1.SelectedLicenseInfo.ExpirationDate);
           lblApplicationFees.Text=ctrLicenseInfoWithFilter1.SelectedLicenseInfo.PaidFees.ToString();
            lblReleseDate.Text =clsFormating.DateToString( ctrLicenseInfoWithFilter1.SelectedLicenseInfo.IssueDate);
            lblTotalFees.Text = (Convert.ToSingle(lblApplicationFees.Text) + ctrLicenseInfoWithFilter1.SelectedLicenseInfo.DetainedInfo.FineFees).ToString();
            lblCreatedBy.Text = clsGlobale.CurrentUser.UserName;
            lblDetainID.Text = ctrLicenseInfoWithFilter1.SelectedLicenseInfo.DetainedInfo.DetainID.ToString();

        }

        private void gpApplicationInfo_Enter(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {



            if(MessageBox.Show("Are you sure do yo want to Relese this License ?", "Confirm",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.No)
            {
                return;
            }
            int ApplicationID=-1;
          bool IsReleased= ctrLicenseInfoWithFilter1.SelectedLicenseInfo.ReleseDetainLicense( ref ApplicationID,clsGlobale.CurrentUser.UserID);
          
            lblReleseAppID.Text=ApplicationID.ToString();

            if (!IsReleased)
            {
                MessageBox.Show("Faild to to release the Detain License", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            MessageBox.Show("Detained License released Successfully ", "Detained License Released", MessageBoxButtons.OK, MessageBoxIcon.Information);

            btnSave.Enabled = false;
            ctrLicenseInfoWithFilter1.FilterEnabled = false;
            llShowLicenseInfo.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void llShowLicenseInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form frm = new frmLicenseInfo(ctrLicenseInfoWithFilter1.LicenseID);
            frm.ShowDialog();
        }

        private void llShowLicenseHistory_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form frm = new frmLicenseHistory(ctrLicenseInfoWithFilter1.SelectedLicenseInfo.DriverInfo.PersonID);
            frm.ShowDialog();
        }

        private void frmReleaceDetainLicense_Load(object sender, EventArgs e)
        {

        }

        private void btnSave_Validating(object sender, CancelEventArgs e)
        {
            if (ctrLicenseInfoWithFilter1.SelectedLicenseInfo.DetainedInfo.IsReleased)
            {
                
                e.Cancel = true;
                btnSave.Enabled = false;
                return;
            }
        }
    }
}
