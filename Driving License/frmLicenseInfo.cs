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
    public partial class frmLicenseInfo : Form
    {
        int _LicenseID;
        public frmLicenseInfo(int LicenseID)
        {
            InitializeComponent();
            _LicenseID = LicenseID;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmLicenseInfo_Load(object sender, EventArgs e)
        {
            ctrLicensInfo1.LoadDriverInfo(_LicenseID);
        }
    }
}
