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

namespace DVLD.Applications.Replicement_For_Damage_or_Lose_License
{
    public partial class frmReplacementForDamageOrLost : Form
    { 

       
        int LicenseID;
        int OldLicenseID;
        clsApplication.enApplicationType ApplicationType;
        clsLicense.enIssueReason IssueReasen;
       
        public frmReplacementForDamageOrLost()
        {
            InitializeComponent();
        }
   private void ctrLicenseInfoWithFilter1_OnLicenseSelected(int obj)
        {
            OldLicenseID = obj;


            if (OldLicenseID == -1)
                return;
            llShowLicenseHistory.Enabled = (OldLicenseID != -1);

            if(!ctrLicenseInfoWithFilter1.SelectedLicenseInfo.IsActive)
            {
               
                    MessageBox.Show("This License Is not Active You should active the License First !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnSave.Enabled = false;
                    return;
                
            }

            if(rbDamage.Checked)
            {
                LoadDamageLicenseApplicationInfo();
                ApplicationType = clsApplication.enApplicationType.ReplacementforDamagedDrivingLicense;
                IssueReasen = clsLicense.enIssueReason.DamagedReplacement;
              
            }else
            {
                LoadLostLicenseApplicationInfo();
                ApplicationType = clsApplication.enApplicationType.ReplacementforLostDrivingLicense;
                IssueReasen = clsLicense.enIssueReason.LostReplacement;
            }
             frmReplacementForDamageOrLost_Load(null, null);
        }
       
       void LoadLostLicenseApplicationInfo()
        {
          
            lblApplicationFees.Text = clsApplicationType.GetApplicationTypeByID((int)clsApplication.enApplicationType.ReplacementforLostDrivingLicense).AppFees.ToString();
       
            lblLicenseFees.Text = ctrLicenseInfoWithFilter1.SelectedLicenseInfo.LicenseClassInfo.ClassFees.ToString();
         
            lblTotalFees.Text = Convert.ToString(Convert.ToSingle(lblLicenseFees.Text) + Convert.ToSingle(lblApplicationFees.Text));

        }
  void LoadApplicationData()
        { lblApplicationDate.Text =clsFormating.DateToString(DateTime.Now);
               lblApplicationID.Text = "[???]";
           lblCreatedBy.Text = clsGlobale.CurrentUser.UserName;
           lblExpirationDate.Text = "[???]";
              lblOldLicenseID.Text = OldLicenseID.ToString();
            lblNewLicenseID.Text = "[???]";



            lblIssueDate.Text = clsFormating.DateToString(DateTime.Now);
        }
        void LoadDamageLicenseApplicationInfo()
        {
           
            lblApplicationFees.Text = clsApplicationType.GetApplicationTypeByID((int)clsApplication.enApplicationType.ReplacementforDamagedDrivingLicense).AppFees.ToString();
        
           
            
           
            lblLicenseFees.Text = ctrLicenseInfoWithFilter1.SelectedLicenseInfo.LicenseClassInfo.ClassFees.ToString();

            lblTotalFees.Text =Convert.ToString( Convert.ToSingle(lblLicenseFees.Text) + Convert.ToSingle(lblApplicationFees.Text));

        }



      
        private void frmReplacementForDamageOrLost_Load(object sender, EventArgs e)
        {
            LoadApplicationData();
        }

     

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Are you sure do you want to Save this Application","Confirm",MessageBoxButtons.OKCancel,MessageBoxIcon.Question)==DialogResult.Cancel)
            {
                return;
            }

            clsLicense NewLicense = ctrLicenseInfoWithFilter1.SelectedLicenseInfo.ReplacmentForDamageOrLose(IssueReasen, ApplicationType, clsGlobale.CurrentUser.UserID);
           
            if(NewLicense==null)
            {
                MessageBox.Show("Saving Proccess Failed ","Failed",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }
            lblExpirationDate.Text = clsFormating.DateToString(NewLicense.ExpirationDate);
            lblApplicationID.Text=NewLicense.ApplicationID.ToString();
            lblNewLicenseID.Text = NewLicense.LicenseID.ToString() ;
            MessageBox.Show("Issue License Saved Seccussfuly ","Saved",MessageBoxButtons.OK,MessageBoxIcon.Exclamation
                ) ;

            llShowLicenseHistory.Enabled = true;
            llShowLicenseInfo.Enabled = true;
            btnSave.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void llShowLicenseInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
          
            Form frm = new frmLicenseInfo( ctrLicenseInfoWithFilter1.SelectedLicenseInfo.LicenseID );
            frm.ShowDialog();
        }

        private void llShowLicenseHistory_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            int PerosnID = ctrLicenseInfoWithFilter1.SelectedLicenseInfo.DriverInfo.PersonID;

            Form frm = new frmLicenseHistory(PerosnID);
            frm.ShowDialog();
        }
    }
}
