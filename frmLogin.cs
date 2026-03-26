using DVLD_BussnisLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }
       
        private void button1_Click(object sender, EventArgs e)
        {
            clsUser User = clsUser.Login(txtUserName.Text, txtPassword.Text);
            
                if (chkRememberMe.Checked)
                {
                    Properties.Settings.Default.UserName = txtUserName.Text;
                    Properties.Settings.Default.Password = txtPassword.Text;
                    Properties.Settings.Default.Save();

                }
                else
                {

                    Properties.Settings.Default.UserName = "";
                    Properties.Settings.Default.Password = "";
                    Properties.Settings.Default.Save();

                }

            clsGlobale.CurrentUser = User;
            if (User == null)
            {
                MessageBox.Show("Wrong UserName /Password  Please Enter again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
                Form Home = new frmHome();
                Home.ShowDialog();


            
        }
        

        private void frmLogin_Load(object sender, EventArgs e)
        {
            txtUserName.Text=Properties.Settings.Default.UserName;
            txtPassword.Text = Properties.Settings.Default.Password;

            if (txtUserName.Text!= "" &&txtPassword.Text!="")
            {
                chkRememberMe.Checked = true;   
            }else
            {
                chkRememberMe.Checked=false;
            }
           
        }

        private void button1_MouseDown(object sender, MouseEventArgs e)
        {
           
        }

        private void chkRememberMe_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
