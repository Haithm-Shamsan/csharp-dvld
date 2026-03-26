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
    public partial class ctrLocalLicenseAppInfo : UserControl
    {
     
        clsLocalDrivingLicenseApplication LocalLicense;
        public ctrLocalLicenseAppInfo()
        {
            InitializeComponent();
            
        }

        public void LoadLocalDrivingLicenseApplication (int LocalDrvingApplicationID)
        {
            LocalLicense = clsLocalDrivingLicenseApplication.GetLocalDrivingLicenseApplication(LocalDrvingApplicationID);

            if(LocalLicense == null)
            {
                MessageBox.Show("There Is No Application With ID : " + LocalDrvingApplicationID + "  !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            lblLocalDrivingLicenseApplicationID.Text = LocalLicense.LocalDrivingLicenseApplicationID.ToString();
            lblAppliedFor.Text = clsLicenseClass.GetLicenseClass(LocalLicense.LicenseClassID).ClassName;
            ctrApplicationBasicInfo1.LoadApplicationInfo(LocalLicense.ApplicationID);
           
            lblPassedTests.Text=clsTestTypes.PassedTests(LocalDrvingApplicationID).ToString();

            if(LocalLicense.IsAlreadyHasLicense())
            {
                llShowLicenceInfo.Enabled = true;
            }
            
        }
        private void ctrLocalLicenseAppInfo_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void ctrApplicationBasicInfo1_Load(object sender, EventArgs e)
        {

        }

        private void llShowLicenceInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //int LicenseID = LocalLicense.GetLicenseID();
            //frmLicenseInfo frm=new frmLicenseInfo(LicenseID);
            //frm.ShowDialog();
        }
    }
}
