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
    public partial class ctrApplicationBasicInfo : UserControl
    {  
       
        int _ApplicationID;
        clsApplication _Application;
        enum enApplicationStatus
        {
            New = 1, Cansle = 2, Compliate = 3
        }
        public ctrApplicationBasicInfo()
        {
           
            InitializeComponent();
        }

        public void  LoadApplicationInfo(int ApplicationId)
        {
            _ApplicationID = ApplicationId;
            _Application = clsApplication.GetApplication(_ApplicationID);
            if(_Application==null)
            {
                MessageBox.Show("There is NO Application With this ID !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
            }
            lblApplicationID.Text = _Application.ApplicationID.ToString();
            lblDate.Text=clsFormating.DateToString(_Application.ApplicationDate);
            lblFees.Text=_Application.PaidFees.ToString();
            lblStatusDate.Text= clsFormating.DateToString(_Application.LastStatusDate);
            lblStatus.Text =clsLocalDrivingLicenseApplication.GetApplication(_ApplicationID).ApplicationStatus.ToString();
            lblApplicant.Text=clsPeople.GetPerson(_Application.ApplicantPersonID).FullName.ToString();
            lblType.Text = clsApplicationType.GetApplicationTypeByID(_Application.ApplicationTypeID).AppTitle;
            lblCreatedByUser.Text = clsUser.GetUser(_Application.CreatedByUserID).UserName;

        }
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void llViewPersonInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Person_Details person = new Person_Details(_Application.ApplicantPersonID);
            person.ShowDialog();
        }
    }
}
