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
    public partial class frmLocalDrivingLicenseAppInfo : Form
    {
        int LocalDrivingLicensID;
        public frmLocalDrivingLicenseAppInfo(int LocalDrvingLicensID)
        {
            InitializeComponent();
            LocalDrivingLicensID = LocalDrvingLicensID;
        }
        clsLocalDrivingLicenseApplication _LocalDrvingApplication;
        private void frmLocalDrivingLicenseAppInfo_Load(object sender, EventArgs e)
        {
            _LocalDrvingApplication = clsLocalDrivingLicenseApplication.GetLocalDrivingLicenseApplication(LocalDrivingLicensID);
            if(_LocalDrvingApplication==null)
            {
                return;
            }
            ctrLocalLicenseAppInfo1.LoadLocalDrivingLicenseApplication(LocalDrivingLicensID);
            ApplicationBasicInfo2.LoadApplicationInfo(_LocalDrvingApplication.ApplicationID);
            
        }

        private void ctrLocalLicenseAppInfo1_Load(object sender, EventArgs e)
        {

        }

        private void ApplicationBasicInfo2_Load(object sender, EventArgs e)
        {

        }
    }
}
