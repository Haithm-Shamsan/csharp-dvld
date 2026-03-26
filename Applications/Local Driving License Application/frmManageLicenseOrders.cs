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
using static DVLD_BussnisLayer.clsApplication;

namespace DVLD
{
    public partial class frmManageLicenseOrders : Form
    {
        public frmManageLicenseOrders()
        {
            InitializeComponent();
        }
        DataTable Applications;
        void _Refreash()
        {
            Applications= clsLocalDrivingLicenseApplication.GetApplications();
            dataGridView1.DataSource = Applications;
            lblRecordsNumber.Text = dataGridView1.ColumnCount.ToString() ;
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frmManageLicenseOrders_Load(object sender, EventArgs e)
        {
            _Refreash();
        }

       private void frmManageLicenseOrders_Opening()
        {
            int LocalDrivingLicenseID = (int)dataGridView1.CurrentRow.Cells[0].Value;

            clsLocalDrivingLicenseApplication LocalDriving = clsLocalDrivingLicenseApplication.GetLocalDrivingLicenseApplication(LocalDrivingLicenseID);

            int PassedTests = (int)dataGridView1.CurrentRow.Cells[5].Value;

            bool LicenseExist= LocalDriving.IsLicenseExist();

            issueToolStripMenuItem.Enabled = (PassedTests == 3)&& !LicenseExist;

            showDetailsToolStripMenuItem.Enabled = LicenseExist;
           
            licenseInfoToolStripMenuItem.Enabled = LicenseExist;
           EditApplication.Enabled = !LicenseExist && (LocalDriving.ApplicationStatus == clsApplication.enApplicationStatus.New);
            schdualToolStripMenuItem.Enabled = !LicenseExist;
            DeleteApplication.Enabled = !LicenseExist && (LocalDriving.ApplicationStatus == clsApplication.enApplicationStatus.New);
            CancleApplication.Enabled= !LicenseExist && (LocalDriving.ApplicationStatus == clsApplication.enApplicationStatus.New);


            bool IsVisionTestPassed = LocalDriving.DoesPassTestType(clsTestTypes.enTestType.Vision);
            bool IsWrittenTestPassed = LocalDriving.DoesPassTestType(clsTestTypes.enTestType.Written);
            bool IsStreetTestPassed = LocalDriving.DoesPassTestType(clsTestTypes.enTestType.Street);


            schdualToolStripMenuItem.Enabled=(!IsVisionTestPassed||!IsWrittenTestPassed||!IsStreetTestPassed)&&LocalDriving.ApplicationStatus==clsApplication.enApplicationStatus.New;


        

            if (schdualToolStripMenuItem.Enabled)
            {
                schdulevisionTestToolStripMenuItem.Enabled = !IsVisionTestPassed;


                sechduleWrittienTestToolStripMenuItem.Enabled = IsVisionTestPassed&&!IsWrittenTestPassed;

               sechduleStreetTestToolStripMenuItem.Enabled=IsVisionTestPassed&&IsWrittenTestPassed&&!IsStreetTestPassed;
            }
                

        }
        private void cmbFilterBy()
        {
            DataView Search = clsApplication.GetApplications().DefaultView;

            txtFilter.Visible = true; ;

            switch (txtFilter.Text)
            {


                case "ApplicationID":
                   
                    if (int.TryParse(txtFilter.Text, out int PersonID))
                    {
                        Search.RowFilter = string.Format("LocalDrivingLicenseApplicationID ='{0}'", PersonID);
                        dataGridView1.DataSource = Search;
                       

                    }


                    break;

                case "NationalNo":
                   
                    Search.RowFilter = " NationalNo like '" + txtFilter.Text + "%'";
                    dataGridView1.DataSource = Search;

                    break;
                case "FullName":
                   
                    // int PersonID = int.Parse(txtFilter.Text);
                    Search.RowFilter = " FullName like '" + txtFilter.Text + "%'";
                    dataGridView1.DataSource = Search;
                    break;
               
                    









            }
        }

        private void txtFilter_TextChanged(object sender, EventArgs e)
        {
           cmbFilterBy();
        }

        private void cbmFilterBy_SelectedIndexChanged(object sender, EventArgs e)
        {
              cmbFilterBy();
           
        }

        private void cbmFilterBy_SelectedValueChanged(object sender, EventArgs e)
        {

        }

        private void cbmFilterBy_MouseClick(object sender, MouseEventArgs e)
        {
          
        }

        private void showDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLocalDrivingLicenseAppInfo frm = new frmLocalDrivingLicenseAppInfo((int)dataGridView1.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
            _Refreash();
        }

        private void EditApplication_Click(object sender, EventArgs e)
        {
            frmNewDrivingLicenseApp frm = new frmNewDrivingLicenseApp(1, (int)dataGridView1.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
            _Refreash();
        }

        private void DeleteApplication_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete this Order", "Confrimation", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation) == DialogResult.Cancel)
            {

                return;

            }
            int LocalDrivingLicenseID = (int)dataGridView1.CurrentRow.Cells[0].Value;

            clsLocalDrivingLicenseApplication LocalDrivingLicensApp = clsLocalDrivingLicenseApplication.GetLocalDrivingLicenseApplication(LocalDrivingLicenseID);


            if (LocalDrivingLicensApp!=null)
            {
                if (LocalDrivingLicensApp.ApplicationStatus == clsApplication.enApplicationStatus.New)

                    if (LocalDrivingLicensApp.DeleteLocalDrivingLicenseApplication())

                        MessageBox.Show("Application Deleted Seccussfully", "Done Seccussfully");

                    else
                        MessageBox.Show("Application Deleted Failed", "Failed Deleteing");
                else
                    MessageBox.Show("you cant delete this Application");
            } 
            _Refreash();
        }

        private void CancleApplication_Click(object sender, EventArgs e)
        {
           


            if (MessageBox.Show("Are you sure you want to Cancle this Order", "Confrimation", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation) == DialogResult.Cancel)
            {

                return;

            }

            int LocalDrivingApplicationID = (int)dataGridView1.CurrentRow.Cells[0].Value;

            clsLocalDrivingLicenseApplication LocalDrivinglicens = clsLocalDrivingLicenseApplication.GetLocalDrivingLicenseApplication(LocalDrivingApplicationID);
           

            if (LocalDrivinglicens != null)
            { 
                

            if (LocalDrivinglicens.ApplicationStatus==clsApplication.enApplicationStatus.New)
            {
                    if(LocalDrivinglicens.Cancel())
                    {

                         MessageBox.Show("Your Application Requst has been cancled seccussfully", "Secceded");
                       _Refreash();
                       return;

                    }
              
            }
            else
            {
                MessageBox.Show("Your Application Requst has'nt been cancled ", "Falied");
            }



            }
          
        }

        private void visionTestToolStripMenuItem_Click(object sender, EventArgs e)
        {

            
            frmTestsAppointments frm=new frmTestsAppointments((int)dataGridView1.CurrentRow.Cells[0].Value,clsTestTypes.enTestType.Vision);
            frm.ShowDialog();
            _Refreash();
        }

        private void sechduleWrittienTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTestsAppointments frm = new frmTestsAppointments((int)dataGridView1.CurrentRow.Cells[0].Value, clsTestTypes.enTestType.Written);
            frm.ShowDialog();
            _Refreash();
        }

        private void sechduleStreetTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTestsAppointments frm = new frmTestsAppointments((int)dataGridView1.CurrentRow.Cells[0].Value, clsTestTypes.enTestType.Street);
            frm.ShowDialog();
            _Refreash();
        }

        private void sedhudalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void issueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new frmIssueDrivingLicense((int)dataGridView1.CurrentRow.Cells[0].Value);
            frm.Enabled = true;
            frm.ShowDialog();
        }

        private void licenseInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int LocalID = (int)dataGridView1.CurrentRow.Cells[0].Value;

            int LicenseID= clsLocalDrivingLicenseApplication.GetLocalDrivingLicenseApplication(LocalID).GetActiveLicenseID();

            frmLicenseInfo frm = new frmLicenseInfo(LicenseID);
            frm.ShowDialog();
            



        }

        private void driverLicenseHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int LocalID = (int)dataGridView1.CurrentRow.Cells[0].Value;
            int PersonID = clsLocalDrivingLicenseApplication.GetLocalDrivingLicenseApplication(LocalID).ApplicantPersonID;
            Form frm = new frmLicenseHistory(PersonID);
                frm.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmNewDrivingLicenseApp frm = new frmNewDrivingLicenseApp(clsGlobale.CurrentUser.UserID, ((int)clsApplication.enApplicationType.AddNewDrivingLicense));
            frm.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void rjDropdownMenu1_Opening(object sender, CancelEventArgs e)
        {
            frmManageLicenseOrders_Opening();
        }
    }
}
