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
    public partial class frmUsers : Form
    {
        public frmUsers()
        {
            InitializeComponent();
        }

        void _Refresh()
        {
            dgvUsers.DataSource = clsUser.GetUsers();
            lblRecordsNumber.Text=dgvUsers.Rows.Count.ToString();
        }
        private void frmUsers_Load(object sender, EventArgs e)
        {
            _Refresh();
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmAddNewUser frm = new frmAddNewUser(-1);
        
            frm.ShowDialog();
            _Refresh();
        }

        void SearchBy()
        {
            DataView SearchBy = clsUser.GetUsers().DefaultView;
            txtFilter.Visible = true;
            switch (cbmFilterBy.SelectedItem)
            { 

                case "UserID":
                    txtFilter.Visible = true;
                    if (int.TryParse(txtFilter.Text, out int UserID))
                    SearchBy.RowFilter =string.Format("UserID ='{0}'",UserID);
                    dgvUsers.DataSource = SearchBy;
                    break;

                case "PersonID":
                    txtFilter.Visible = true;
                    // int PersonID = int.Parse(txtFilter.Text);
                    if (int.TryParse(txtFilter.Text, out int PersonId))
                        SearchBy.RowFilter = string.Format("PersonID ='{0}'", PersonId);
                    dgvUsers.DataSource = SearchBy;

                    break;
                case "UserName":
                    txtFilter.Visible = true;
                    SearchBy.RowFilter = "UserName LIKE '" + txtFilter.Text + "%'";
                    dgvUsers.DataSource= SearchBy;

                    break;
                case "IsActive":
                    txtFilter.Visible = false;
                    cmbIsActive.Visible = true;

                    switch(cmbIsActive.SelectedItem)
                    {
                        case "Yes":
                            int IsActive = 1;
                            SearchBy.RowFilter = string.Format("IsActive='{0}'", IsActive);
                            dgvUsers.DataSource = SearchBy;
                            break;
                        case "No":
                            int NotActive = 0;

                            SearchBy.RowFilter = string.Format("IsActive='{0}'", NotActive);
                            dgvUsers.DataSource=SearchBy;
                            break;
                    }
                   
                    

                    break;

            }
        }
        private void showDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new Person_Details((int)dgvUsers.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
        }

        private void txtFilter_TextChanged(object sender, EventArgs e)
        {
           
            SearchBy();
           
        }

        private void cbmFilterBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtFilter.Visible = true;

        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            
            Form frm = new frmAddNewUser((int)dgvUsers.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
            _Refresh();
        }

        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new frmChangePassword((int)dgvUsers.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
            _Refresh();
        }

        private void addNewUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new frmAddNewUser(-1);
                frm.ShowDialog();
                _Refresh();
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form frm = new frmUserDetails((int)dgvUsers.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
        }

        private void dgvUsers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtFilter_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(cbmFilterBy.Text=="UserID"||cbmFilterBy.Text=="PersonID")
                e.Handled=!char.IsDigit(e.KeyChar)&&!char.IsControl(e.KeyChar);
        }
    }
}
