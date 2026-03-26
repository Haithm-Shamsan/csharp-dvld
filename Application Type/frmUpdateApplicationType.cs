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
    public partial class frmUpdateApplicationType : Form
    {
        int _AppID;

        clsApplicationType _ApplicationType;
        public frmUpdateApplicationType(int AppID)
        {
            InitializeComponent();
            _AppID = AppID;
        }

        void LoadData()
        {
            _ApplicationType =clsApplicationType.GetApplicationTypeByID(_AppID);

            if (_ApplicationType == null )
            {
                MessageBox.Show("Wrong ApplicationID","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }
            lblApplicationID.Text = _ApplicationType.AppID.ToString();
            txtTitle.Text=_ApplicationType.AppTitle;
            txtFees.Text = _ApplicationType.AppFees.ToString();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmUpdateApplicationType_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            _ApplicationType.AppTitle = txtTitle.Text;
            _ApplicationType.AppFees = Convert.ToDecimal(txtFees.Text);

            if(_ApplicationType.Save())
            {
                MessageBox.Show("Application Updated Seccussfully", "Updated Seccussfully", MessageBoxButtons.OK);
                this.Close();
                    
            }else
            {
                MessageBox.Show("Application Update Failed", "Update Failed", MessageBoxButtons.OK);
                this.Close();
            }

        }
    }
}
