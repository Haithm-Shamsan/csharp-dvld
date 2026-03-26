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
    public partial class frmUserDetails : Form
    {
        int _UserID;
        clsUser _User;
        public frmUserDetails(int UserID)
        {
            InitializeComponent();

           _UserID = UserID;
        }

      
      
        private void frmUserDetails_Load(object sender, EventArgs e)
        {
            ctrUserInfo1.LoadUserData(_UserID);
        }

        private void ctrUserInfo1_Load(object sender, EventArgs e)
        {
            
        }

        private void ctrUserInfo1_Load_1(object sender, EventArgs e)
        {

        }
    }
}
