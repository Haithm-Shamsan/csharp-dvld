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
    public partial class Person_Details : Form
    {
        int _PerosnID;
        public Person_Details(int PersonID)
        {
            InitializeComponent();
            _PerosnID = PersonID;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ctrPersonCard1_Load(object sender, EventArgs e)
        {
            ctrPersonCard1.LoadPersonInfo(_PerosnID);
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmEditAddNewPerson frm = new frmEditAddNewPerson(_PerosnID);
            frm.ShowDialog();
        }

        private void Person_Details_Load(object sender, EventArgs e)
        {

        }
    }
}
