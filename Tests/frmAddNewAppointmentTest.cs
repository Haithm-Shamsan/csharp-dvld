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
    public partial class frmAddNewAppointmentTest : Form
    {
       public enum enMode { Update,AddNew}
        public enMode Mode = enMode.AddNew;

        int _LocalDrivingLicensAppID;
        int _AppointmentTestID;
        clsTestTypes.enTestType _TestType;

        public frmAddNewAppointmentTest(int LocalDrivingLicensAppID, clsTestTypes.enTestType TestTypeID,int AppointmentTestID=-1 )
        {
            InitializeComponent();
            _LocalDrivingLicensAppID= LocalDrivingLicensAppID;
            _AppointmentTestID= AppointmentTestID;  
            _TestType = TestTypeID;
        }
      
        private void frmAddNewAppointmentTest_Load(object sender, EventArgs e)
        {
            ctrSchduleTest1._TestType = _TestType;
            ctrSchduleTest1.LoadSchduleAppointment(_LocalDrivingLicensAppID, _AppointmentTestID);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ctrSchduleTest1_Load(object sender, EventArgs e)
        {

        }
    }
}
