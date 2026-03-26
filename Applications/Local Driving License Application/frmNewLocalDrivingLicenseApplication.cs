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
    public partial class frmNewDrivingLicenseApp : Form
    {
       
        int PersonIDFromOnPersnSelected;
        clsLocalDrivingLicenseApplication _LocalDrivingLicens;
       
        clsUser _CurrentUser;
      
        int _ApplicationID;
        enum enMode { Update ,AddNew}
        enMode Mode;
        enum enApplicationStatus
        {
           New=1,Cancle=2,Completed=3
        }
        enApplicationStatus Status;

        int _UserID ;

        public frmNewDrivingLicenseApp(int UserID,int ApplicationID)
        {
            InitializeComponent();
          _UserID = UserID;
            _ApplicationID = ApplicationID;
            _CurrentUser = clsUser.GetUser(UserID);
            if (_ApplicationID == ((int)clsApplication.enApplicationType.AddNewDrivingLicense))
            {
                Mode = enMode.AddNew;
            }
            else
            {
                Mode = enMode.Update;
            }

            
        }
        void FillComboBox()
        {
            DataTable Classes = clsLicenseClass.GetLicenseClasses();
            foreach(DataRow row in Classes.Rows)
            {
                cmbClasses.Items.Add(row["ClassName"]);
            }

        }
        void LoadData()
        { FillComboBox ();
            if(Mode==enMode.AddNew)
            {
               _LocalDrivingLicens=new  clsLocalDrivingLicenseApplication();
                lblMode.Text = "Add New Local Driving License";
                lblAppID.Text = "[???]";
                lblDate.Text = DateTime.Now.ToString();
                
                lblFees.Text = (string)clsApplicationType.GetApplicationTypeByID(_ApplicationID).AppFees.ToString();
                lblCreatedBy.Text = clsPeople.GetPerson(_CurrentUser.PersonID).FullName;
                return;
            }
           



            _LocalDrivingLicens =  clsLocalDrivingLicenseApplication.GetLocalDrivingLicenseApplication(_ApplicationID);
            if (_LocalDrivingLicens == null )
            {
                MessageBox.Show("Wrong locale Driving License Applicaiton ID");

                return;
            
            }
            PersonIDFromOnPersnSelected = _LocalDrivingLicens.ApplicantPersonID;
            ctrPersonCardWithFilter1.LoadUserInfo(_UserID);
            ctrPersonCardWithFilter1.Enabled = false;
            _ApplicationID = _LocalDrivingLicens.ApplicationID;
            cmbClasses.SelectedItem = clsLicenseClass.GetLicenseClass(_LocalDrivingLicens.LicenseClass.LicenseClassID).ClassName;
           
            lblDate.Text=_LocalDrivingLicens.ApplicationDate.ToString();
            lblFees.Text = _LocalDrivingLicens.PaidFees.ToString();
            lblCreatedBy.Text=_LocalDrivingLicens.CreatedByUserID.ToString();
           
           
           

        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (PersonIDFromOnPersnSelected != -1)
            {

                if (clsUser.IsUserExistByUserID(PersonIDFromOnPersnSelected))
                {

                    MessageBox.Show("Selected Person already has a user, choose another one.", "Select another Person", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }

                else
                {
                    btnSave.Enabled = true;
                    tabControl1.Enabled = true;
                    tbApplicationInfo.Show();
                    tbApplicationInfo.BringToFront();

                }
            }

            else

            {
                MessageBox.Show("Please Select a Person", "Select a Person", MessageBoxButtons.OK, MessageBoxIcon.Error);


            }
        }

        private void tbpersonInfo_Click(object sender, EventArgs e)
        {

        }

        private void ctrPersonCardWithFilter1_OnPersonSelected(int obj)
        {
            PersonIDFromOnPersnSelected = obj;
        }

        private void frmNewDrivingLicenseApp_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {  
           _LocalDrivingLicens.ApplicantPersonID = ctrPersonCardWithFilter1.PersonID;
            _LocalDrivingLicens.ApplicationDate = DateTime.Now;
            _LocalDrivingLicens.LastStatusDate = DateTime.Now;
            _LocalDrivingLicens.PaidFees = Convert.ToDecimal(lblFees.Text);
            _LocalDrivingLicens.ApplicationStatus = clsApplication.enApplicationStatus.New;
           
            _LocalDrivingLicens.LicenseClassID = clsLicenseClass.GetLicenseClassByName(cmbClasses.SelectedItem.ToString()).LicenseClassID;
            _LocalDrivingLicens.ApplicationTypeID = (int)clsApplication.enApplicationType.AddNewDrivingLicense;
            _LocalDrivingLicens.CreatedByUserID = clsGlobale.CurrentUser.UserID;

            int LicenseID = clsApplication.IsThereActiveLicense(_LocalDrivingLicens.ApplicantPersonID, _LocalDrivingLicens.ApplicationTypeID, _LocalDrivingLicens.LicenseClassID);
           if(LicenseID!=-1)
            {
                MessageBox.Show("You Already has this license !","Worning",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }
          

            if (_LocalDrivingLicens.Save())
            {
                MessageBox.Show("Your Requset done Seccussfully", "Seccussful Request", MessageBoxButtons.OK);
              
                lblAppID.Text = _LocalDrivingLicens.LocalDrivingLicenseApplicationID.ToString();
                Mode = enMode.Update;
             
                    
            }else
            {
                MessageBox.Show("Your Requset has Failed", "Filed Request", MessageBoxButtons.OK);
            }
        }

        private void ctrPersonCardWithFilter1_Load(object sender, EventArgs e)
        {
            ctrPersonCardWithFilter1.LoadUserInfo(PersonIDFromOnPersnSelected);
        }

        private void ctrPersonCardWithFilter1_Load_1(object sender, EventArgs e)
        {

        }

        private void ctrPersonCardWithFilter1_OnPersonSelected_1(int obj)
        {
            PersonIDFromOnPersnSelected = obj;
        }

        private void ctrPersonCardWithFilter1_Load_2(object sender, EventArgs e)
        {

        }
    }
}
