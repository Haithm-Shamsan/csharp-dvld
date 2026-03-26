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
    public partial class frmLicenseHistory : Form
    {

        int _PersonID;
        clsDriver _Driver;
        public frmLicenseHistory(int PersonID)
        {
            InitializeComponent();
            _PersonID = PersonID;
        }

        void LoadDriverHistory()
        {
            _Driver=clsDriver.GetDriverByPersonID(_PersonID);
            if(_Driver == null ) 
            {
              MessageBox.Show("There is No Driver With this ID !","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
                this.Close();
            }

            ctrPersonCard1.LoadPersonInfo(_Driver.PersonID);
            ctrDriverLicenses1.LoadLicenseInfo(_Driver.DriverID);
        }
        private void frmLicenseHistory_Load(object sender, EventArgs e)
        {
            LoadDriverHistory();
        }

        private void ctrPersonCard1_OnPersonSelected(int obj)
        {
           
        }

        private void ctrDriverLicenses1_Load(object sender, EventArgs e)
        {

        }

        private void ctrPersonCard1_Load(object sender, EventArgs e)
        {

        }
    }
}
