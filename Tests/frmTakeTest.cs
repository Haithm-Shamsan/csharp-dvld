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
    public partial class frmTakeTest : Form
    {

        public clsTest _Test;
        clsTestTypes.enTestType _TestType;
        int TestID;
        int _TestAppointmentID;
        public frmTakeTest(int TestAppointmentID,clsTestTypes.enTestType TestTypeID)
        {
            InitializeComponent();
            
            _TestType=TestTypeID;
           _TestAppointmentID= TestAppointmentID;
        }

        void LoadTestInfo()
        {
            
            ctrSchduledTest1._TestType= _TestType;
            ctrSchduledTest1.LoadSchduledInfo( _TestAppointmentID);


           
            if(ctrSchduledTest1.TestAppointmentID==-1)
            {
                btnSave.Enabled = false;
            }else
            {
                btnSave.Enabled = true;
            }

            int TestID = ctrSchduledTest1.TestID;

            if(TestID!=-1)
            {
                _Test = clsTest.Find(TestID);

               

                if (_Test.TestResult)
                    rbPass.Checked = true;
                else
                    rbFail.Checked = true;
                txtNotes.Text = _Test.Notes;

                lblUserMessage.Visible = true;
                rbFail.Enabled = false;
                rbPass.Enabled = false;


            }
            else
            {
                _Test = new clsTest();
                rbFail.Enabled = true;
                rbPass.Enabled = true;
            }
           
            
        }
        private void frmTakeTest_Load(object sender, EventArgs e)
        {
            LoadTestInfo();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            _Test.TestResult = rbPass.Checked;
            _Test.TestAppointmentID = _TestAppointmentID;
            _Test.Notes= txtNotes.Text.Trim();
           
            _Test.CreatedByUserID = clsGlobale.CurrentUser.UserID;
           

            if (MessageBox.Show("Are You sure do you want to Save this Resulte ", "Worning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.Cancel)
            {
                return;
            }
            else 
            {  
                
                if(_Test.Save())
                {
                    if(MessageBox.Show("Test Resulte Saved Seccussfully", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)==DialogResult.OK)
                    {
                        this.Close();
                    }
                   
                }
 
            }
        }

        private void ctrSchduledTest1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
