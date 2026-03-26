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
    public partial class frmTestsAppointments : Form
    {

        int _LocalDrivingLicensAppID;
        DataTable TestData;
     
         clsTestTypes.enTestType _TestType;

        public frmTestsAppointments(int LocalAppID,clsTestTypes.enTestType TestType)
        {
            InitializeComponent();

            _TestType = TestType;
            _LocalDrivingLicensAppID=LocalAppID;
        }

        
        void _Refreash()
        {
            dataGridView1.DataSource= clsTestTypes.GetTestAppointmentsByTestType(_LocalDrivingLicensAppID, _TestType);
        }

        private void frmTestsAppointments_Load(object sender, EventArgs e)
        {
            ctrLocalLicenseAppInfo1.LoadLocalDrivingLicenseApplication(_LocalDrivingLicensAppID);

             TestData= clsTestTypes.GetTestAppointmentsByTestType(_LocalDrivingLicensAppID, _TestType);
            _Refreash();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            clsLocalDrivingLicenseApplication LocalDrivingLicensApp = clsLocalDrivingLicenseApplication.GetLocalDrivingLicenseApplication(_LocalDrivingLicensAppID);

            if(LocalDrivingLicensApp.IsThereActiveTest(_TestType))
            {
                MessageBox.Show("There Is An Active Test You should pass it first", "Worning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            clsTest LastTest =LocalDrivingLicensApp.GetLastTestByTestTypeAndTestID(_TestType);

            if(LastTest==null)
            {
                frmAddNewAppointmentTest frm = new frmAddNewAppointmentTest(_LocalDrivingLicensAppID, _TestType);
                frm.ShowDialog();
                return;
            }

            if(LastTest.TestResult==true)
            {
                MessageBox.Show("You Cant Schdule Test that have been already Passed ","Worning",MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            frmAddNewAppointmentTest frm2=new frmAddNewAppointmentTest(LastTest.TestAppointmentInfo.LocalDrivingLicenseApplicationID, _TestType);
           
            frm2.ShowDialog();
            _Refreash();
          
           
        }

        private void takeTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTakeTest frm=new frmTakeTest((int)dataGridView1.CurrentRow.Cells[0].Value,_TestType);
            frm.ShowDialog();
            frmTestsAppointments_Load(null, null);
        }
    }
}
