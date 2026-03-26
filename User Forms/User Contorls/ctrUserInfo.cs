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
    public partial class ctrUserInfo : UserControl
    {
        public ctrUserInfo()
        {
            InitializeComponent();
        }
        clsUser _User;

        string IsActive(bool IsActive)
        {
            if (IsActive)
            {
                return lblIsActive.Text = "Yes";
            }else
            {
                return lblIsActive.Text = "No";
            }
        }
       public void LoadUserData(int UserID)
        {
            if(clsUser.GetUser(UserID) == null)
            {
                MessageBox.Show("Could'nt Find This User");
                return;
            }
            _User = clsUser.GetUser(UserID);

            ctrPersonCard1.LoadPersonInfo(_User.PersonID);
            lblUserID.Text = _User.UserID.ToString();
            lblUserName.Text = _User.UserName;
            IsActive(_User.IsActive);


            
        }
    }
}
