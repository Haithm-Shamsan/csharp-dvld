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
    public partial class frmIssueDrivingLicense : Form
    {

        int _LocalDrivingLicneseAppID;
        clsLocalDrivingLicenseApplication _LocalDrivingLicense;

        public frmIssueDrivingLicense(int LocalDrivingLiceneID)
        {
            InitializeComponent();

            _LocalDrivingLicneseAppID = LocalDrivingLiceneID;
        }

        void LoadLocalInfo()
        {
            _LocalDrivingLicense = clsLocalDrivingLicenseApplication.GetLocalDrivingLicenseApplication(_LocalDrivingLicneseAppID);
            if(_LocalDrivingLicense==null)
            {
                MessageBox.Show("There Is no LocalDrivinglincese With this ID","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }

            if(!_LocalDrivingLicense.DoesPassAllTests())
            {
                MessageBox.Show("The Applicant Didnt Pass All Tests ID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            ctrLocalLicenseAppInfo1.LoadLocalDrivingLicenseApplication(_LocalDrivingLicneseAppID);
           


        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnIssueLicense_Click(object sender, EventArgs e)
        {

           int LicenseID= _LocalDrivingLicense.IssueLicenseFirstTime(txtNotes.Text, clsGlobale.CurrentUser.UserID);

            if (LicenseID != -1)
            {
                MessageBox.Show("License Issued Successfully with License ID = " + LicenseID.ToString(),
                    "Succeeded", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.Close();
            }
            else
            {
                MessageBox.Show("License Was not Issued ! ",
                 "Faild", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void ctrLocalLicenseAppInfo1_Load(object sender, EventArgs e)
        {

        }

        private void frmIssueDrivingLicense_Load(object sender, EventArgs e)
        {
            LoadLocalInfo();
        }
    }
}
