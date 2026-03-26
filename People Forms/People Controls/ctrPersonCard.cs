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
    public  partial class ctrPersonCard : UserControl
    {
        public  int _PersonID;
        clsPeople _Person;
        public ctrPersonCard()
        {
            InitializeComponent();

          
        }

        public event Action<int> OnPersonSelected;

        protected virtual void PersonSelected(int personID)
        {
            Action<int> handler = OnPersonSelected;
            if (handler != null)
            {
                handler(_PersonID);
            }
        }


        string FullName()
        {
            return _Person.FirstName + " " + _Person.SecondName + " " + _Person.ThirdName + " " + _Person.LastName;

        }
        
         string GetGender()
        {
           if(_Person.Gendor==0)
            {
                return lblGender.Text = "Male";
              
            }else
            {
                return lblGender.Text = "Famale";
                
            }
        }

        public  void LoadPersonInfo(int PersonID)
        {
           

            _Person=clsPeople.GetPerson(PersonID);
         
            if(_Person == null ) 
             {
                MessageBox.Show("There is no person with this ID");
                return;
            }
            _PersonID = _Person.PersonID;
          
            if(OnPersonSelected != null)
                OnPersonSelected(PersonID);
               
            lblPersonID.Text = _Person.PersonID.ToString();
            lblName.Text=FullName();
            lblCountry.Text = clsCountry.GetCountryByID( _Person.CountryInfo.CountryID).CountryName;
            lblGender.Text = GetGender();
            lblEmail.Text=_Person.Email;
            lblDate.Text = clsFormating.DateToString(_Person.DateOfBirth);
            lblPhone.Text = _Person.Phone;
            lblNationalNo.Text=_Person.NationalNo;
            lblAddress.Text = _Person.Address;

            pictureBox1.ImageLocation = _Person.ImagePath;
           

        }
        public void LoadPersonInfo(string NationalNo)
        {
            

            _Person = clsPeople.GetPerson(NationalNo);
            if (_Person == null)
            {
                MessageBox.Show("There is no person with this ID");
                return;
            }
            _PersonID= _Person.PersonID;
            lblPersonID.Text = _Person.PersonID.ToString();
            lblName.Text = FullName();
            lblCountry.Text = _Person?.CountryInfo.CountryName;
            lblGender.Text = GetGender();
            lblEmail.Text = _Person.Email;
            lblDate.Text = clsFormating.DateToString(_Person.DateOfBirth);
            lblPhone.Text = _Person.Phone;
            lblNationalNo.Text = _Person.NationalNo;
            lblAddress.Text = _Person.Address;

            pictureBox1.ImageLocation= _Person.ImagePath;


        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void linklblAddphoto_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            openFileDialog1.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                // Process the selected file
                string selectedFilePath = openFileDialog1.FileName;
                //MessageBox.Show("Selected Image is:" + selectedFilePath);

                pictureBox1.Load(selectedFilePath);
                // ...

               
            }
        }
            private void openFileDialog2_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void linklblRemove_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
           
        }

        private void ctrPersonCard_Load(object sender, EventArgs e)
        {

        }
    }
}
