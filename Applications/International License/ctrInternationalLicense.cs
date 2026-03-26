using DVLD.Properties;
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
    public partial class ctrInternationalLicense : UserControl
    {

        int _InternationalLicenseID;
        clsInternationalLicense _InternationalLicense;
        public ctrInternationalLicense()
        {
            InitializeComponent();
        }
    
        public clsInternationalLicense SelectedLicenseInfo
        {
            get
            {
                return _InternationalLicense;
            }
        }



       
        public void LoadInfo(int InternationalLicenseID)
        {
            _InternationalLicenseID = InternationalLicenseID;
            _InternationalLicense = clsInternationalLicense.Find(_InternationalLicenseID);
            if (_InternationalLicense == null)
            {
                MessageBox.Show("Could not find Internationa License ID = " + _InternationalLicenseID.ToString(),
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                _InternationalLicenseID = -1;
                return;
            }

            lblInternationalLicenseID.Text = _InternationalLicense.InternationalLicenseID.ToString();
            lblApplicationID.Text = _InternationalLicense.ApplicationID.ToString();
            lblIsActive.Text = _InternationalLicense.IsActive ? "Yes" : "No";
            lblLocalLicenseID.Text = _InternationalLicense.IssuedUsingLocalLicenseID.ToString();
            lblFullName.Text = _InternationalLicense.DriverInfo._PersonInfo.FullName;
            lblNationalNo.Text = _InternationalLicense.DriverInfo._PersonInfo.NationalNo;
            lblGendor.Text = _InternationalLicense.DriverInfo._PersonInfo.Gendor == 0 ? "Male" : "Female";
            lblDateOfBirth.Text = clsFormating.DateToString(_InternationalLicense.DriverInfo._PersonInfo.DateOfBirth);
           
            lblDriverID.Text = _InternationalLicense.DriverID.ToString();
            lblIssueDate.Text = clsFormating.DateToString(_InternationalLicense.IssueDate);
            lblExpirationDate.Text = clsFormating.DateToString(_InternationalLicense.ExpirationDate);

           if(_InternationalLicense.DriverInfo._PersonInfo.ImagePath!=null)
            {
                pbPersonImage.Load(_InternationalLicense.DriverInfo._PersonInfo.ImagePath);
            }else
            {
                pbPersonImage.Load(null);
            }



        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
