using DVLD.Applications.Detain_License;
using DVLD.Applications.Replicement_For_Damage_or_Lose_License;
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
    public partial class frmHome : Form
    {

        public frmHome()
        {
            InitializeComponent();
          
            
        }
        int PersonID;
        clsGlobale CurrentUser;
        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void UserInfo_Click(object sender, EventArgs e)
        {
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
           
        }

        private void LogOut_Click(object sender, EventArgs e)
        {
            
        }

        private void button6_Click(object sender, EventArgs e)
        {
           
        }

        private void peopleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new frmPeople();
            frm.ShowDialog();

        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void usersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new frmUsers();
            frm.ShowDialog();
        }

        private void currentUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new frmUserDetails(clsGlobale.CurrentUser.UserID);
            frm.ShowDialog();
        }

        private void ctrUserInfo1_Load(object sender, EventArgs e)
        {
          
        }

        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmChangePassword frm = new frmChangePassword(clsGlobale.CurrentUser.UserID);
            frm.ShowDialog();
        }

        private void manageApplicationTypesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmManageApplicationTypes frm = new frmManageApplicationTypes();
            frm.ShowDialog();
        }

        private void manageTestsTypesToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void replToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new frmReplacementForDamageOrLost();
            frm.ShowDialog();
        }

        private void localLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
              frmNewDrivingLicenseApp frm = new frmNewDrivingLicenseApp(clsGlobale.CurrentUser.UserID,((int)clsApplication.enApplicationType.AddNewDrivingLicense));
            frm.ShowDialog();
        }

        private void ctrPersonCard1_Load(object sender, EventArgs e)
        {
            
           
        }

        private void dsfToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void applicationBasicInfo1_Load(object sender, EventArgs e)
        {
           
        }

        private void localDrivingLicenseApplicatationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmManageLicenseOrders frm = new frmManageLicenseOrders();
            frm.ShowDialog();
            
        }

        private void driversToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDriversList frm = new frmDriversList();
            frm.ShowDialog();
        }

        private void internationalLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new frmAddNewInterNationalDrivingLicense();
            frm.ShowDialog();
        }

        private void internationalDrivingLicensApplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new frmInternationalLicensList();
            frm.ShowDialog();
        }

        private void renewDrivingLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new frmRenewDrivingLicense();
            frm.ShowDialog();
        }

        private void applicationsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void detainLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new frmDetainLicense();
            frm.ShowDialog();
        }

        private void manageDetainLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new frmManageDetainLicenses();
            frm.ShowDialog();
        }

        private void relaseLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new frmReleaceDetainLicense();
            frm.ShowDialog();
        }

        private void retakeTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmManageLicenseOrders frm = new frmManageLicenseOrders();
            frm.ShowDialog();
        }
    }
}
