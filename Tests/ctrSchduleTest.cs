using DVLD.Properties;
using DVLD_BussnisLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static DVLD_BussnisLayer.clsTestTypes;

namespace DVLD
{
    public partial class ctrSchduleTest : UserControl
    {
        enum enMode { Update ,AddNew}
        enMode Mode=enMode.AddNew;

        enum enCreationMode { SchduleFirstTime,SchdulRetakeeTest}
        enCreationMode CreationMode=enCreationMode.SchduleFirstTime;

        int _LocalDrivingLicensID;
        clsLocalDrivingLicenseApplication _LocalDrivingLicens;
        clsTestAppointment _TestAppointment;
        int _TestAppointmentID;
        public clsTestTypes.enTestType _TestType;
        


       
         void TestType()
        {
            switch (_TestType)
            {
                case clsTestTypes.enTestType.Vision:
                    pbTestTypeImage.Image = imageList1.Images[0];
                    lblTitle.Text = "Schdule Vision Test";
                    break;
                case clsTestTypes.enTestType.Written:
                    pbTestTypeImage.Image = imageList1.Images[1];
                    lblTitle.Text = "Schdule Wrttien Test";
                    break;
                case clsTestTypes.enTestType.Street:
                    pbTestTypeImage.Image = imageList1.Images[2];
                    lblTitle.Text = "Schdule Street Test";
                    break;
            }
           
        }
       









        public ctrSchduleTest()
        {
            InitializeComponent();
          
        }

        public void LoadSchduleAppointment(int LocalDrivingLicensAppID,int AppointmentTestID)
        {
            TestType();
            LoadTestTitleAndImage();

            if (AppointmentTestID == -1)
                Mode = enMode.AddNew;
            else
                Mode = enMode.Update;




            _LocalDrivingLicensID = LocalDrivingLicensAppID;
              _TestAppointmentID = AppointmentTestID;
            _LocalDrivingLicens = clsLocalDrivingLicenseApplication.GetLocalDrivingLicenseApplication(LocalDrivingLicensAppID);

            if(_LocalDrivingLicens== null)
            {
                MessageBox.Show("Error There Is No Local Driving License ID With This Number " + LocalDrivingLicensAppID, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

                btnSave.Enabled = true;
                return;
            }

            if(_LocalDrivingLicens.DoesAttededTestType(_TestType))
            {
                CreationMode=enCreationMode.SchdulRetakeeTest;
            }else
            {
                CreationMode = enCreationMode.SchduleFirstTime;
            }


            if(CreationMode==enCreationMode.SchdulRetakeeTest)
            {
                gbRetakeTestInfo.Enabled = true; ;
                lblTitle.Text = "Schdule Retake Test";
                lblRetakeAppFees.Text=clsApplicationType.GetApplicationTypeByID((int)clsApplication.enApplicationType.RetakeTest).AppFees.ToString();
                lblRetakeTestAppID.Text = "0";
               
            }else
            {
                gbRetakeTestInfo.Enabled = false ; 
                lblTitle.Text = "Schdule Test";
                lblRetakeAppFees.Text ="0" ;
                lblRetakeTestAppID.Text = "N/A";
            }

            lblLocalDrivingLicenseAppID.Text =_LocalDrivingLicens.LocalDrivingLicenseApplicationID.ToString();
          
            lblDrivingClass.Text = _LocalDrivingLicens.LicenseClass.ClassName;
            lblFullName.Text = clsPeople.GetPerson(_LocalDrivingLicens.ApplicantPersonID).FullName;         
            lblTrial.Text = _LocalDrivingLicens.TotalTriesPerTest(_TestType).ToString();



            if(Mode==enMode.AddNew)
            {
                lblTitle.Text = "Add New Appoinment Test";
                lblFees.Text = clsApplicationType.GetApplicationTypeByID((int)clsLocalDrivingLicenseApplication.enApplicationType.AddNewDrivingLicense).AppFees.ToString();
                lblLocalDrivingLicenseAppID.Text = "N/A";
                _TestAppointment = new clsTestAppointment();
            }else
            {
                if (!_LoadTestAppointmentData())
                    return;

            }
            lblTotalFees.Text = (Convert.ToSingle(lblFees.Text) + Convert.ToSingle(lblRetakeAppFees.Text)).ToString();


        }


        bool _LoadTestAppointmentData()
        {
           _TestAppointment = clsTestAppointment.Find(_TestAppointmentID);


            if(_TestAppointment == null)
            {
                MessageBox.Show("Error There Is No Local Driving License ID With This Number " + _TestAppointmentID, "Error",
                       MessageBoxButtons.OK, MessageBoxIcon.Error);

                btnSave.Enabled=true;
                return false ;

            }

            lblFees.Text = _TestAppointment.PaidFees.ToString();
            if (DateTime.Compare(  DateTime.Now,_TestAppointment.AppointmentDate)< 0)
                 dtpTestDate.Value = DateTime.Now;
            else
                dtpTestDate.Value=_TestAppointment.AppointmentDate;

            if(_TestAppointment.RetakeTestApplicationID==-1)
            {
                lblRetakeAppFees.Text = "0";
                lblRetakeTestAppID.Text = "N/A";
            }else
            {
                lblRetakeAppFees.Text = _TestAppointment.RetakeTestAppInfo.PaidFees.ToString();
                lblRetakeTestAppID.Text=_TestAppointment.RetakeTestApplicationID.ToString();
                gbRetakeTestInfo.Enabled = true;
                lblTitle.Text = "Rechdule Retake Test";

            }
            return true;





        }
       public void LoadTestTitleAndImage()
        {

            switch (_TestType)
            {
                case clsTestTypes.enTestType.Vision:
                    lblTitle.Text = "Vision Test Appoinments";
                    pbTestTypeImage.Image = imageList1.Images[0];
                    
                    break;

                case clsTestTypes.enTestType.Written:
                    lblTitle.Text = "Written Test Appoinments";
                    pbTestTypeImage.Image =imageList1.Images[1];
                    break;

                case clsTestTypes.enTestType.Street:
                    lblTitle.Text = "Street Test Appoinments";
                    pbTestTypeImage.Image = imageList1.Images[2];
                    break;
            }
        }
        private void ctrSchduleTest_Load(object sender, EventArgs e)
        {

        }

        private void gbTestType_Enter(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            _TestAppointment.LocalDrivingLicenseApplicationID = _LocalDrivingLicens.LocalDrivingLicenseApplicationID;
            _TestAppointment.TestTypeID= _TestType;
            _TestAppointment.AppointmentDate = dtpTestDate.Value;
            
            _TestAppointment.PaidFees = Convert.ToSingle(lblFees.Text);
            _TestAppointment.CreatedByUserID = clsGlobale.CurrentUser.UserID;
            
            if(_TestAppointment.Save())
            {
                MessageBox.Show("Test Appointment Saved Seccussfully ", "Saved Seccussfully", MessageBoxButtons.OK)
                    ;
                Mode = enMode.Update;
               
            }

        }

        private void lblTrial_Click(object sender, EventArgs e)
        {

        }
    }
}
