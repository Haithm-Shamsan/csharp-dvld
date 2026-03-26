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
using System.IO;
using DVLD_BussnisLayer;

namespace DVLD
{
    public partial class frmEditAddNewPerson : Form
    {

        enum enMode { Update, AddNew };
        enMode Mode = enMode.AddNew;
        int _PersonID;
        clsPeople _Person;

        public delegate void DataBackEventHandler(object o,int PersonID);
        public static event  DataBackEventHandler DataBack;
        
        public frmEditAddNewPerson(int PersonId)
        {
            InitializeComponent();
            _PersonID = PersonId;
            if (_PersonID == -1)
            {
                Mode = enMode.AddNew;
                lblMode.Text = "Add New Person";
            }
            else
            {
                Mode = enMode.Update;
                lblMode.Text = "Update person";
            }
        }


        
        byte GetGenderTypeToSave()
        {
            if (rdbMale.Checked == true)
            {
                return 0;
            } else if (rdbFamale.Checked == true)
            {
                return 2;
            }
            return 0;
        }
        void LoadCountries()
        {
            DataTable Data = clsCountry.GerCounries();
            foreach (DataRow row in Data.Rows)
            {
                cmbCountry.Items.Add(row["CountryName"]);
            }
        }
        void LoadData()
        { 
           dateOfBirth.Value = DateTime.Now.AddYears(-18);
            LoadCountries();
            cmbCountry.SelectedIndex = 0;
            if (Mode == enMode.AddNew)
            {
                pictureBox1.Image = imageList1.Images[0];
                rdbMale.Checked = true;
                _Person = new clsPeople();

                return;
            }
            _Person = clsPeople.GetPerson(_PersonID);
            if (_Person == null)
            {
                MessageBox.Show("There is No Person With this ID");
                return;
            }
      cmbCountry.SelectedIndex = cmbCountry.FindString(clsCountry.GetCountryByID(_Person.NationalityCountryID).CountryName);
            txtFirstName.Text = _Person.FirstName;
            txtSecondName.Text = _Person.SecondName;
            txtThirdName.Text = _Person.ThirdName;
            txtLastName.Text = _Person.LastName;
            txtNationalNo.Text = _Person.NationalNo;
            txtEmail.Text = _Person.Email;
            txtPhone.Text = _Person.Phone;
            txtAddress.Text = _Person.Address;
            if(_Person.Gendor==0)
            {
                rdbMale.Checked = true;
                rdbFamale.Checked = false;
            }else
            {
                rdbFamale.Checked=true;
                rdbMale.Checked=false;
            }
            dateOfBirth.Value = _Person.DateOfBirth;
           lblPersonID.Text = _Person.PersonID.ToString();
          
          pictureBox1.ImageLocation=_Person.ImagePath;

        }
        private void frmEditAddNewPerson_Load(object sender, EventArgs e)
        {
            LoadData();


        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
           
           
        }

        private void rdbMale_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox1.Image = imageList1.Images[0];
        }

        private void rdbFamale_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox1.Image = imageList1.Images[1];
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
            }
        }

        bool  _HandleImage()
        {
            if(_Person.ImagePath!=pictureBox1.ImageLocation)
            {
                if(_Person.ImagePath!="")
                {

                    try
                    {
                        File.Delete(_Person.ImagePath);
                    }catch(IOException)
                    {
                        //Say what you want here
                    }




                }

                if(pictureBox1.ImageLocation!=null)
                {


                    string SourcePath=pictureBox1.ImageLocation.ToString();

                   if(clsutil.CopyImageToProjectImagesFolder(ref SourcePath))
                    {
                        pictureBox1.ImageLocation = SourcePath;
                    }else
                    {
                        MessageBox.Show("Error Copying Image File", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }

                }


            }
            return true;

        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!_HandleImage())
                return;


           

            _Person.FirstName=txtFirstName.Text;
            _Person.SecondName=txtSecondName.Text;
            _Person.ThirdName=txtThirdName.Text;
            _Person.LastName=txtLastName.Text;
            _Person.Email=txtEmail.Text;
            _Person.NationalNo = txtNationalNo.Text;
            _Person.Phone=txtPhone.Text;
            _Person.DateOfBirth = dateOfBirth.Value;
            _Person.Address=txtAddress.Text;
            _Person.Gendor = GetGenderTypeToSave();
            _Person.ImagePath = pictureBox1.ImageLocation; 
            _Person.NationalityCountryID = clsCountry.GetCountryByName(cmbCountry.Text).CountryID ;

            if(_Person.Save())
            { Refresh();
                MessageBox.Show("Saved");
                Mode = enMode.Update;
                lblMode.Text = "Update Person";
                lblPersonID.Text = _Person.PersonID.ToString() ;
               
            }else
            {
                MessageBox.Show("It sucks");
            }

           
        }

        private void button1_Click(object sender, EventArgs e)
        { 
          

            DataBack?.Invoke(this, _Person.PersonID);
            this.Close();
           
            Refresh();
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            if(clsFormating.IsValiedEmail(txtEmail.Text)==false)
            {
                errorProvider1.SetError(txtEmail, "Please Enter Valied Email !");
            }else
            {
                errorProvider1.Clear();
            }
        }

        private void txtNationalNo_TextChanged(object sender, EventArgs e)
        {
           
            if(clsPeople.IsNationalNoExist(txtNationalNo.Text))
            {
                errorProvider1.SetError(txtNationalNo, "This NationalNo Is Exist Enter another No");
                txtNationalNo.Focus();
               
            
            }else
            {
                errorProvider1.Clear();
            }
        }

        private void dateOfBirth_ValueChanged(object sender, EventArgs e)
        {
          
            dateOfBirth.Format=DateTimePickerFormat.Short;
        }

        private void linklblRemove_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            pictureBox1.ImageLocation = "";
        }
    }
}
