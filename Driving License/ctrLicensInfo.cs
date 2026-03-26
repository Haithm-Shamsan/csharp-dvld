using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DVLD_BussnisLayer;

namespace DVLD
{
    public partial class ctrLicensInfo : UserControl
    {
        public clsLicense License;
        public int _LicenseID;
        public ctrLicensInfo()
        {
            InitializeComponent();
        }


        public clsLicense SelectedLicenseInfo
        {
            get
            {
                return License;
            }
        }
 public void LoadDriverInfo(int LicenseID)
        {


             License = clsLicense.Find(LicenseID);
            
            if(License==null)
            {
                MessageBox.Show("There IS No Driver With this ID !","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }


            _LicenseID = LicenseID;
            lblClass.Text = License.LicenseClassInfo.ClassName;
            lblDateOfBirth.Text = clsFormating.DateToString(License.DriverInfo._PersonInfo.DateOfBirth);
            lblDriverID.Text = License.DriverID.ToString();
          
            lblExpirationDate.Text=clsFormating.DateToString(License.ExpirationDate);
            lblDriverID.Text=License.DriverID.ToString();   
            lblFullName.Text=License.DriverInfo._PersonInfo.FullName;
            if (License.DriverInfo._PersonInfo.Gendor == 0)
                lblGendor.Text = "Male";
            else
                lblGendor.Text = "Famale";
            lblIssueReason.Text = License.IssueReasonText;
            lblLicenseID.Text= License.LicenseID.ToString();
            lblNationalNo.Text = License.DriverInfo._PersonInfo.NationalNo;
            lblIssueDate.Text = clsFormating.DateToString(License.IssueDate);
            lblNotes.Text = License.Notes;
            lblIsDetained.Text = License.IsDetained ? "Yes" : "No";

            
               
            if (License.IsActive == true)

                lblIsActive.Text="Yes";
            else
            
                lblIsActive.Text = "No";
            
          
            
            if(License.DriverInfo._PersonInfo.ImagePath != null)
            {
                pbPersonImage.ImageLocation=License.DriverInfo._PersonInfo.ImagePath;
            }else
            {
                pbPersonImage.ImageLocation=null;
            }
           

        }
        private void groupBox1_Enter(object sender, EventArgs e)
        {
        
        }

        private void lblIssueDate_Click(object sender, EventArgs e)
        {

        }
    }
}
