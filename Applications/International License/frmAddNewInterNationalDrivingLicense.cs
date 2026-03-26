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
    public partial class frmAddNewInterNationalDrivingLicense : Form
    {
        int _LicenseID;
        int _InternationalLicenseID;
        clsInternationalLicense _InterLicense;
        
        public frmAddNewInterNationalDrivingLicense()
        {
            InitializeComponent();
        }

        void LoadAppInfo()
        {
              
              
        }
        private void ctrLicenseInfoWithFilter1_OnLicenseSelected(int obj)
        {
            _LicenseID = obj;

            lblLocalLicenseID.Text = _LicenseID.ToString();
            lblLocalLicenseID.Text = _LicenseID.ToString();

            llShowLicenseHistory.Enabled = (obj != -1);
            if (_LicenseID == -1) 
            {
                return;
            }

            if(ctrLicenseInfoWithFilter1.SelectedLicenseInfo.LicenseClass!=3)
            {
                MessageBox.Show("You Should have License From Class 3 Otherwise you cant issue international license", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int ActiveInternaionalLicenseID = clsInternationalLicense.GetActiveInternationalLicenseIDByDriverID(ctrLicenseInfoWithFilter1.SelectedLicenseInfo.DriverID);

            if (ActiveInternaionalLicenseID != -1)
            {
                MessageBox.Show("Person already have an active international license with ID = " + ActiveInternaionalLicenseID.ToString(), "Not allowed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                llShowLicenseInfo.Enabled = true;
                _InternationalLicenseID = ActiveInternaionalLicenseID;
               btnSave.Enabled = false;
                return;
            }



            llShowLicenseHistory.Enabled = true;



        }

        private void ctrLicenseInfoWithFilter1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            int DriverID = ctrLicenseInfoWithFilter1.SelectedLicenseInfo.DriverID;

            if(clsInternationalLicense.GetActiveInternationalLicenseIDByDriverID(DriverID)==1)
            {
                MessageBox.Show("There is an active License With this driver","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;

            }

            if (ctrLicenseInfoWithFilter1.SelectedLicenseInfo.LicenseClass != 3)
            {
                MessageBox.Show("You Should have License From Class 3 Otherwise you cant issue international license", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int ActiveInternaionalLicenseID = clsInternationalLicense.GetActiveInternationalLicenseIDByDriverID(ctrLicenseInfoWithFilter1.SelectedLicenseInfo.DriverID);

            if (ActiveInternaionalLicenseID != -1)
            {
                MessageBox.Show("Person already have an active international license with ID = " + ActiveInternaionalLicenseID.ToString(), "Not allowed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                llShowLicenseInfo.Enabled = true;
                _InternationalLicenseID = ActiveInternaionalLicenseID;
                btnSave.Enabled = false;
                return;
            }


            _InterLicense = new clsInternationalLicense();

            _InterLicense.ApplicantPersonID = ctrLicenseInfoWithFilter1.SelectedLicenseInfo.DriverInfo.PersonID;
            _InterLicense.ApplicationDate=DateTime.Now;
            _InterLicense.ApplicationStatus = clsApplication.enApplicationStatus.Completed;
            _InterLicense.PaidFees = clsApplicationType.GetApplicationTypeByID((int)clsApplication.enApplicationType.AddNewInternationalLicense).AppFees; 
            _InterLicense.CreatedByUserID = clsGlobale.CurrentUser.UserID;
            _InterLicense.DriverID = ctrLicenseInfoWithFilter1.SelectedLicenseInfo.DriverID;
            _InterLicense.ExpirationDate = DateTime.Now.AddYears(1);
            _InterLicense.IsActive = true;
            _InterLicense.IssueDate = DateTime.Now;
            _InterLicense.LastStatusDate = DateTime.Now;
            _InterLicense.IssuedUsingLocalLicenseID = ctrLicenseInfoWithFilter1.SelectedLicenseInfo.LicenseID;


            if(!_InterLicense.Save())
            {

                MessageBox.Show("Faild to Issue International License", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }

            lblLocalLicenseID.Text = _InterLicense.ApplicationID.ToString();
            _InternationalLicenseID = _InterLicense.InternationalLicenseID;
            lblInternationalID.Text = _InterLicense.InternationalLicenseID.ToString();

            MessageBox.Show("International License Issued Successfully with ID=" + _InterLicense.InternationalLicenseID.ToString(), "License Issued", MessageBoxButtons.OK, MessageBoxIcon.Information);

            btnSave.Enabled = false;
            ctrLicenseInfoWithFilter1.FilterEnabled = false ;
            llShowLicenseInfo.Enabled = true;
            llShowLicenseHistory.Enabled = true;
        }

        private void ctrApplicationBasicInfo1_Load(object sender, EventArgs e)
        {

        }

        private void llShowLicenseInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmLicenseInfo frm = new frmLicenseInfo(ctrLicenseInfoWithFilter1.LicenseID);
            frm.ShowDialog();
        }

        private void llShowLicenseHistory_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmLicenseHistory frm = new frmLicenseHistory(ctrLicenseInfoWithFilter1.SelectedLicenseInfo.DriverInfo.PersonID);
            frm.ShowDialog();
        }

        private void ctrLicenseInfoWithFilter1_Load_1(object sender, EventArgs e)
        {

        }

        private void frmAddNewInterNationalDrivingLicense_Load(object sender, EventArgs e)
        {
            lblApplicationID.Text = "[????]";
            lblCreatedByUser.Text = clsGlobale.CurrentUser.UserName;
            lblDate.Text = clsFormating.DateToString(DateTime.Now);
            lblFees.Text = clsApplicationType.GetApplicationTypeByID((int)clsApplication.enApplicationType.AddNewInternationalLicense).AppFees.ToString();
            lblExpirationDate.Text=clsFormating.DateToString(DateTime.Now.AddYears(1));
            lblApplicationDate.Text = clsFormating.DateToString(DateTime.Now);





        }

        private void lblLocalLicenseID_Click(object sender, EventArgs e)
        {

        }

        private void ctrLicenseInfoWithFilter1_OnLicenseSelected_1(int obj)
        {

        }
    }
}
