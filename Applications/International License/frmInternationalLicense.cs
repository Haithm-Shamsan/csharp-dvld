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
    public partial class frmInternationalLicense : Form
    {

        int _LicenseID;
        public frmInternationalLicense(int LicenseID)
        {
            InitializeComponent();
            _LicenseID = LicenseID;
        }

        private void frmInternationalLicense_Load(object sender, EventArgs e)
        {
            ctrInternationalLicense1.LoadInfo(_LicenseID);
        }

        private void ctrInternationalLicense1_Load(object sender, EventArgs e)
        {

        }

        private void ctrInternationalLicense1_Load_1(object sender, EventArgs e)
        {

        }
    }
}
