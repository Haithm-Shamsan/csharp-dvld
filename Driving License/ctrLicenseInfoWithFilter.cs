using DVLD_BussnisLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD
{
    public partial class ctrLicenseInfoWithFilter : UserControl
    {
        public ctrLicenseInfoWithFilter()
        {
            InitializeComponent();
        }

        public event Action<int> OnLicenseSelected;

        protected virtual void LicenseSelected(int LicenseID)
        {
            Action<int> handler = OnLicenseSelected;
            if (handler != null)
            {
                handler(LicenseID);
            }
        }

     

        public int LicenseID
        {
            get { return ctrLicensInfo1._LicenseID; }
        }

        public clsLicense SelectedLicenseInfo
        {  get{
                
                return ctrLicensInfo1.SelectedLicenseInfo; 
            
            
            }
        }
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        public void FilterEnable()
        {
            txtSearch.Enabled = false;
            btnSearch.Enabled = false;
        }
        public bool  FilterEnabled
        {
            set {  txtSearch.Enabled = true; }
            get { return txtSearch.Enabled; }
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            int LicenseID = Convert.ToInt16(txtSearch.Text);

            ctrLicensInfo1.LoadDriverInfo(LicenseID);

            OnLicenseSelected(LicenseID);
           
        }
        public void LoadInfo(int LicenseID)
        {
            ctrLicensInfo1.LoadDriverInfo(LicenseID);

            OnLicenseSelected(LicenseID);
        }
        private void ctrLicenseInfoWithFilter_Load(object sender, EventArgs e)
        {

        }

        private void ctrLicensInfo1_Load(object sender, EventArgs e)
        {

        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
