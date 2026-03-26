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
    public partial class frmChangePassword : Form
    {
        int _UserID;
        clsUser _User;
        public frmChangePassword(int UserId)
        {
            InitializeComponent();
            _UserID = UserId;

        }

        bool CheckCurrentPassword(string CurrentPassword)
        {
            bool IsCorrect = false;
            if (string.IsNullOrEmpty(CurrentPassword))
                IsCorrect= false;

            if (CurrentPassword!= _User.Password)
                errorProvider1.SetError(txtCurrentPassword, "Wrong Password Please Enter again!");
          
            else
                errorProvider1.Clear();

            if (CurrentPassword == _User.Password)
                IsCorrect =  true;

            return IsCorrect;
        }

      


        void LoadData()
        {
            _User = clsUser.GetUser(_UserID);
            if(_User==null)
            {
                MessageBox.Show("There is No Perosn With this User","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }
            ctrUserInfo1.LoadUserData(_User.UserID);

        }
        private void frmChangePassword_Load(object sender, EventArgs e)
        {
            
            LoadData();



        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            _User.Password = txtNewPassword.Text;
           

            if(!clsUser.IsCurrentUserPasswordCorrect(txtCurrentPassword.Text))
            {
                MessageBox.Show("Wrong Password If you forget it Contact your Admin", "Wrong Password", MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }
            
            if(_User.Save())
            {
                MessageBox.Show("Password Changed Seccussfully","Password Saved",MessageBoxButtons.OK);
            }else
            {
                MessageBox.Show("Something Wrong Happend Please Contact Your Admin", "Password Saved", MessageBoxButtons.OK);
            }
        }

        private void txtCurrentPassword_TextChanged(object sender, EventArgs e)
        {
            CheckCurrentPassword(txtCurrentPassword.Text);
        }

        private void txtConfirmNewPassword_Validating(object sender, CancelEventArgs e)
        {
            if (txtCurrentPassword.Text.Trim() != txtConfirmNewPassword.Text.Trim())
            {
                e.Cancel = true ;
                errorProvider1.SetError(txtCurrentPassword, "You should fill this box");
                errorProvider1.SetError(txtConfirmNewPassword, "You should fill this box");
            }
            else
            {
                errorProvider1.Clear();
            }
        }
    }
}
