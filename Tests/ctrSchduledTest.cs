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
    public partial class ctrSchduledTest : UserControl
    {
        public ctrSchduledTest()
        {
            InitializeComponent();
        }

        clsTestAppointment _TestAppointment;
        clsLocalDrivingLicenseApplication _LocalDrivingLicens;
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


        public int TestAppointmentID
        {
            get { return _TestAppointmentID; }

        }
        int _TestAppointmentID=-1;
        int _TestID=-1;
        public int TestID
        {
            get { return _TestID; }
        }
        public void LoadSchduledInfo(int TestAppointmentID)
        {

            TestType();
            _TestAppointment = clsTestAppointment.Find(TestAppointmentID);
            _TestAppointmentID =_TestAppointment.TestAppointmentID;

            if (_TestAppointment == null)
            {
                MessageBox.Show("There Is No Test Appointment With this ID","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }
          _TestID= _TestAppointment.TestID;
            _LocalDrivingLicens = clsLocalDrivingLicenseApplication.GetLocalDrivingLicenseApplication(_TestAppointment.LocalDrivingLicenseApplicationID);

            lblLocalDrivingLicenseAppID.Text =_TestAppointment.LocalDrivingLicenseApplicationID.ToString();
            lblFullName.Text = clsPeople.GetPerson(_LocalDrivingLicens.ApplicantPersonID).FullName;
            lblDate.Text = _TestAppointment.AppointmentDate.ToString();
            lblDrivingClass.Text = _LocalDrivingLicens.LicenseClass.ClassName;
            lblFees.Text=_TestAppointment.PaidFees.ToString();
            lblTrial.Text = _LocalDrivingLicens.TotalTriesPerTest((clsTestTypes.enTestType)_TestAppointment.TestID).ToString();
            lblTitle.Text = clsTestTypes.GetTestTypeByID((int)_TestType).TestTitle;





        }
        private void gbTestType_Enter(object sender, EventArgs e)
        {

        }
    }
}
