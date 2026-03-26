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
    public partial class frmPeople : Form
    { 
        
        public frmPeople()
        {
            InitializeComponent();  
            lblRecordsNumber.Text = clsPeople.RecordsNumber().ToString();
        }

        void _Refresh()
        {
            dataGridView1.DataSource = clsPeople.GetPeople();
         
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frmPeople_Load(object sender, EventArgs e)
        {
            _Refresh();
            
        }

        private void cmbFilterBy()
        {
            DataView Search = clsPeople.GetPeople().DefaultView;
            txtFilter.Visible = true;
           
            switch(cbmFilterBy.SelectedItem)
            {


                case "PersonID":
                   
                    if(int.TryParse(txtFilter.Text,out int PersonID))
                    {
                        Search.RowFilter = string.Format("PersonID ='{0}'", PersonID);
                   

                    }
                    dataGridView1.DataSource = Search;

                    break;

                case "NationalNo":
                   
                    Search.RowFilter = " NationalNo like '" + txtFilter.Text + "%'";
                    dataGridView1.DataSource = Search;

                    break;
                case "FirstName":
                   // int PersonID = int.Parse(txtFilter.Text);
                    Search.RowFilter = " FirstName like '" + txtFilter.Text + "%'";
                    dataGridView1.DataSource = Search;

                    break;

                case "SecondName":
                    // int PersonID = int.Parse(txtFilter.Text);
                    Search.RowFilter = " SecondName like '" + txtFilter.Text + "%'";
                    dataGridView1.DataSource = Search;

                    break;
                case "LastName":
                    // int PersonID = int.Parse(txtFilter.Text);
                    Search.RowFilter = " LastName like '" + txtFilter.Text + "%'";
                    dataGridView1.DataSource = Search;

                    break;
                case "Gender":
                    // int PersonID = int.Parse(txtFilter.Text);
                    Search.RowFilter = " GendorCaption like '" + txtFilter.Text + "%'";
                    dataGridView1.DataSource = Search;

                    break;
                case "Phone":
                    // int PersonID = int.Parse(txtFilter.Text);
                    Search.RowFilter = " Phone like '" + txtFilter.Text + "%'";
                    dataGridView1.DataSource = Search;

                    break;
                case "Email":
                    // int PersonID = int.Parse(txtFilter.Text);
                    Search.RowFilter = " FirstName like '" + txtFilter.Text + "%'";
                    dataGridView1.DataSource = Search;

                    break;











            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            frmEditAddNewPerson frm = new frmEditAddNewPerson(-1);
            frm.ShowDialog();
            _Refresh();
        }

        private void editInfromationToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
        }

        private void mShowDetails_Click(object sender, EventArgs e)
        {
           
        }

        private void showDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        { Person_Details person = new Person_Details((int)dataGridView1.CurrentRow.Cells[0].Value);
            person.ShowDialog();
            _Refresh();
        }

        private void editInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {  frmEditAddNewPerson frm=new frmEditAddNewPerson((int)dataGridView1.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
            _Refresh();

        }

        private void deletePersonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Are you sure do you want to delete this person","Worning",MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                if(clsPeople.DeletPerson((int)dataGridView1.CurrentRow.Cells[0].Value))
                { 
                    
                    MessageBox.Show("Person Deleted Seccussfully","",MessageBoxButtons.OK);
                    _Refresh();
                }
            }
        }

        private void cbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void txtFilter_TextChanged(object sender, EventArgs e)
        {
            cmbFilterBy();
          
        }

        private void cbmFilterBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtFilter.Visible = true;
            _Refresh();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
           
        }

 //       private void btnClose_Click_1(object sender, EventArgs e)
 //       {
 //this.Close();
 //       }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
