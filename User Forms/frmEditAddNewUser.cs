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
    public partial class frmAddNewUser : Form
    { 
      
       
        int _PersonID;
        int PersonIDFromOnPersnSelected;
        enum enMode { Update,AddNew}
        enMode Mode=enMode.AddNew;
        int _UserID;
        clsUser _User;

      
        public frmAddNewUser(int UserID)
        {
            InitializeComponent();

            _UserID = UserID;

            if(UserID==-1)
            {
                Mode = enMode.AddNew;
                lblMode.Text = "Add New User";
                label1.Text = "Add New User";

            }
            else
            {
                Mode = enMode.Update;
               
                lblMode.Text = "Update User";
                label1.Text = "Update User";
            }

           
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
        }


        void LoadData()
        {
            if(Mode==enMode.AddNew)
            {
                _User = new clsUser();
                lblMode.Text = "Add New User";
                return;
            }
            if (Mode == enMode.Update)
            {
                btnSavee.Enabled = true;
                tabControl1.Enabled = true;

               
            }
            _User = clsUser.GetUser(_UserID);

            if(_User== null)
            {
                MessageBox.Show("There is no User With this ID","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }
            lblMode.Text = "Update User";
            ctrPersonCardWithFilter1.LoadUserInfo(_User.PersonID);
            txtUserName.Text = _User.UserName;
            txtPassword.Text = _User.Password;
            txtCoformPassword.Text = _User.Password;
            chkIsActive.Checked= _User.IsActive;




        }
        private void button1_Click(object sender, EventArgs e)
        {
            Form frm = new frmEditAddNewPerson(-1);
            frmEditAddNewPerson.DataBack+=DataBack;
            frm.ShowDialog();

           
        }


        void DataBack(object O,int PersonID)
        {
            _PersonID= PersonID;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
           
             frmEditAddNewPerson frm = new frmEditAddNewPerson(ctrPersonCardWithFilter1.PersonID);
             frm.ShowDialog();

            
           
        }

        private void frmAddNewUser_Load(object sender, EventArgs e)
        { 
            
            LoadData();
            Cursor = Cursors.Default;
            
        }
       
        private void button1_Click_1(object sender, EventArgs e)
        {
           

            //incase of add new mode.
            if (PersonIDFromOnPersnSelected != -1)
            {

                if (clsUser.IsUserExistByUserID(PersonIDFromOnPersnSelected))
                {

                    MessageBox.Show("Selected Person already has a user, choose another one.", "Select another Person", MessageBoxButtons.OK, MessageBoxIcon.Error);
                   
                }

                else
                {
                    btnSavee.Enabled = true;
                    tabControl1.Enabled = true;
                    tabPage2.Show();
                    tabPage2.BringToFront();
                    
                }
            }

            else

            {
                MessageBox.Show("Please Select a Person", "Select a Person", MessageBoxButtons.OK, MessageBoxIcon.Error);
               

            }

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {
          
        }

        private void txtCoformPassword_TextChanged(object sender, EventArgs e)
        {
            if(txtCoformPassword.Text!=txtPassword.Text)
            {
                errorProvider1.SetError(txtCoformPassword, "Wrong Password");
            }else
            {
                errorProvider1.Clear();
            }
        }

        private void btnSavee_Click(object sender, EventArgs e)
        {
            
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {
           
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnSavee_Click_1(object sender, EventArgs e)
        {
            _User.PersonID= ctrPersonCardWithFilter1.PersonID;
            _User.UserName = txtUserName.Text;
            _User.Password = txtPassword.Text;
            _User.IsActive = chkIsActive.Checked;



            if(clsUser.IsUserExistByPersonID(_User.PersonID))
            {
                MessageBox.Show("this Person has an account Try Again Or Connect your Admin");
                return;
              
            }
            if (_User.Save())
            {

                MessageBox.Show("User Saved Seccussfully", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                this.Close();
            
            }
            else
            {
                MessageBox.Show("User Saving Failed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ctrPersonCardWithFilter1_OnPersonSelected(int obj)
        {
           PersonIDFromOnPersnSelected = obj;
          
        }

        private void ctrPersonCardWithFilter1_Load(object sender, EventArgs e)
        {

        }

        private void tabPage2_MouseClick(object sender, MouseEventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_MouseClick(object sender, MouseEventArgs e)
        {
           
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
