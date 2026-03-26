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
    public partial class ctrDriverLicenses : UserControl
    {

        int _DriverID;
        int _PersonID;
        clsDriver _Driver;
        public ctrDriverLicenses()
        {
            InitializeComponent();
        }



       void LoadLocalDrivingLisencesInfo()
        {
            dataGridView1.DataSource = clsDriver.GetLocalDrivingLicense(_DriverID);



            dataGridView1.Columns[0].HeaderText = "Lic.ID";
            dataGridView1.Columns[0].Width = 100;

            dataGridView1.Columns[1].HeaderText = "App.ID";
            dataGridView1.Columns[1].Width = 100;


            dataGridView1.Columns[2].HeaderText = "Class Name";
            dataGridView1.Columns[2].Width = 270;
        }

        void LoadInternationalDrivingLisencesInfo()
        {
            dataGridView2.DataSource = clsInternationalLicense.GetDriverInternationalLicensesByDriverID(_DriverID);




        }

        public  void LoadLicenseInfo(int DriverID)
        {
            _DriverID = DriverID;
            _Driver=clsDriver.GetDriverByID(DriverID);
            if(_Driver!=null)
                _DriverID=_Driver.DriverID;
            LoadLocalDrivingLisencesInfo();
            LoadInternationalDrivingLisencesInfo();

        }
        public void LoadLicenseInfoByPersonID(int PersonID)
        {
            _PersonID = PersonID;

            _Driver = clsDriver.GetDriverByID(PersonID);

            if (_Driver != null)

                _PersonID=_Driver.PersonID;
                LoadLocalDrivingLisencesInfo();
            LoadInternationalDrivingLisencesInfo();

        }

        public void LoadInternatonalInfoByPersonID(int PersonID)
        {
            _PersonID = PersonID;
            _Driver = clsDriver.GetDriverByID(PersonID);
            if (_Driver != null)
                LoadLocalDrivingLisencesInfo();
            LoadInternationalDrivingLisencesInfo();
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void licenseInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            Form frm = new frmLicenseInfo((int)dataGridView1.CurrentRow.Cells[0].Value);
                frm.ShowDialog();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void licenseInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new frmInternationalLicense((int)dataGridView2.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
        }
    }
}
