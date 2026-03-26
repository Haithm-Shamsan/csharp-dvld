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
    public partial class frmUpdateTest : Form
    {

        int TestID;
        clsTestTypes _TestType;
        public frmUpdateTest(int TestID)
        {
            InitializeComponent();
            this.TestID = TestID;
        }

        void LoadData()
        {
            _TestType = clsTestTypes.GetTestTypeByID(TestID);

            if (_TestType == null)
            {
                MessageBox.Show("Wrong TestID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            lblTestID.Text = _TestType.TestID.ToString();
            txtTitle.Text = _TestType.TestTitle;
            txtDescription.Text= _TestType.TestDescription;
            txtFees.Text = _TestType.TestFees.ToString();
        }
        private void frmUpdateTest_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            _TestType.TestTitle = txtTitle.Text;
            _TestType.TestDescription= txtDescription.Text;
            _TestType.TestFees=Convert.ToDecimal(txtFees.Text);

            if(_TestType.Save())
            {
                MessageBox.Show("Application Updated Seccussfully", "Updated Seccussfully", MessageBoxButtons.OK);
                this.Close();

            }
            else
            {
                MessageBox.Show("Application Update Failed", "Update Failed", MessageBoxButtons.OK);
                this.Close();
            }
        }
    }
}
