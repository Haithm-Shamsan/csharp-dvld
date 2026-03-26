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
    public partial class frmDetainLicense : Form
    {

        int LicenseID;
        clsDetainedLicense _DetainLicense = new clsDetainedLicense();
        public frmDetainLicense()
        {
            InitializeComponent();
        }

        void LoadData()
        {
            lblApplicationDate.Text = clsFormating.DateToString(DateTime.Now);
            lblCreatedBy.Text=clsGlobale.CurrentUser.UserName;
            
           
        }
        private void ctrLicenseInfoWithFilter1_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void ctrLicenseInfoWithFilter1_OnLicenseSelected(int obj)
        {
            LicenseID = obj;
            lblLicenseID.Text = LicenseID.ToString();
            if (LicenseID == -1)
                return;



            bool IsDetained=clsDetainedLicense.IsLicenseDetained(LicenseID);

            if(IsDetained)
            {
                MessageBox.Show("This License Is Already Detained !","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }

            clsLicense License = clsLicense.Find(LicenseID);

            if(License == null)
            {
                MessageBox.Show("There is no License With This ID","Wrong License ID",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }
           llShowLicenseHistory.Enabled= true;
            llShowLicenseInfo.Enabled= true;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            _DetainLicense.CreatedByUserID=clsGlobale.CurrentUser.UserID;
            _DetainLicense.DetainDate = Convert.ToDateTime(lblApplicationDate.Text);
            _DetainLicense.FineFees = Convert.ToSingle(txtFineFees.Text);
            _DetainLicense.LicenseID= LicenseID;
            
            if(MessageBox.Show("Are you sure do you want to Detain this License ?","Confirm",MessageBoxButtons.OKCancel) == DialogResult.Cancel) 
            {
                return;
            
            }

            if(_DetainLicense.Save())
            {
               lblApplicationID.Text=_DetainLicense.DetainID.ToString(); 
                MessageBox.Show("Detain License Saved Seccussfully", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }

            
        }

        private void frmDetainLicense_Load(object sender, EventArgs e)
        {

        }

        private void llShowLicenseInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form frm = new frmLicenseInfo(LicenseID);
            frm.ShowDialog();
        }

        private void llShowLicenseHistory_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form frm = new frmLicenseHistory(clsLicense.Find(LicenseID).DriverInfo.PersonID);
            frm.ShowDialog();
        }
    }
}
